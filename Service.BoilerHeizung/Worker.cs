using Business.Dto.Dto;
using CrossCutting.Utility.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Service.BoilerHeizung
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly App_Settings _options ;
        private UserDto user;
        private DateTime newToken;

        public Worker(ILogger<Worker> logger, IOptions<App_Settings> options)
        {
            _logger = logger;
            _options = options.Value;

            newToken = DateTime.Now;
            user = new UserDto { Username = _options.ApiUsername, Password = _options.ApiPassword, Token = "" };

        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            int timeout = _options.TimeoutService_Seconds;
            while (!stoppingToken.IsCancellationRequested)
            {

                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                }

                if (_options.IsEnabled)
                {
                    try
                    {
                        await Work();
                    }catch(Exception ex)
                    {
                        _logger.LogError("Error Worker :", ex);
                    }
                }
                await Task.Delay(timeout * 1000, stoppingToken);
            }
        }


        private async Task Work()
        {
            _logger.LogInformation("Worker Start");
            ServicePointManager.ServerCertificateValidationCallback += (sender_, cert, chain, sslPolicyErrors) => true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            if (user.Token == "" || newToken <= DateTime.Now)
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(_options.ApiUrl);
                var response = await client.PostAsJsonAsync("api/Users/Authenticate", user);
                if (response.IsSuccessStatusCode)
                {
                    var u = await response.Content.ReadAsAsync<UserDto>();
                    user.Token = u.Token;
                    newToken = DateTime.Now.AddHours(12);
                }
                else
                {
                    user.Token = "";
                }
            }
            ElectricMeterDataDto electricMeterDataDto = null;
            if (!string.IsNullOrEmpty(user.Token))
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(_options.ApiUrl);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", user.Token);
                var response = await client.GetAsync("api/modbus/GetAktuellElectricMeterData");
                if (response.IsSuccessStatusCode)
                {
                    var str = await response.Content.ReadAsStringAsync();
                    electricMeterDataDto = JsonConvert.DeserializeObject<ElectricMeterDataDto>(str);


                }
            }

            BoilerHeizungDto boilerHeizungDto = null;

            if (!string.IsNullOrEmpty(_options.ApiTokenMyPV))
            {
                var clientMyPV = new HttpClient();
                clientMyPV.BaseAddress = new Uri(_options.ApiUrlMyPV);
                clientMyPV.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _options.ApiTokenMyPV);
                var response = await clientMyPV.GetAsync(_options.ApiSerialNumberMyPV +"/data");
                if (response.IsSuccessStatusCode)
                {
                    var str = await response.Content.ReadAsStringAsync();
                    boilerHeizungDto = JsonConvert.DeserializeObject<BoilerHeizungDto>(str);
                }
            }

            if (!string.IsNullOrEmpty(_options.ApiTokenMyPV))
            {
                if(boilerHeizungDto != null && electricMeterDataDto != null)
                {
                    var power = CalcPower(boilerHeizungDto, electricMeterDataDto);

                    if(power != boilerHeizungDto.power_ac9){

                        var clientMyPV = new HttpClient();
                        clientMyPV.BaseAddress = new Uri(_options.ApiUrlMyPV);
                        clientMyPV.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _options.ApiTokenMyPV);
                        BoilerHeizungPowerDto boilerHeizungPowerDto = new BoilerHeizungPowerDto { validForMinutes = 10, power = (power * 2), timeBoostOverride = 0, timeBoostValue = 0, legionellaBoostBlock = 0, batteryDischargeBlock = 0 };

                        var response = await clientMyPV.PostAsJsonAsync(_options.ApiSerialNumberMyPV + "/power", boilerHeizungPowerDto);
                        if (response.IsSuccessStatusCode)
                        {
                            var str = await response.Content.ReadAsStringAsync();
                        }
                    }
                }
            }
        }

        private int CalcPower(BoilerHeizungDto boilerHeizungDto, ElectricMeterDataDto electricMeterDataDto)
        {
            int powerAktuell = (int)electricMeterDataDto.currentPowerSum ;
            if ((boilerHeizungDto.power_ac9 - powerAktuell) < 1500)
            {
                return 0;
            }

            int newPower = ((powerAktuell * -1) + boilerHeizungDto.power_ac9) - 200;

            if (checkedPowerSize(newPower, boilerHeizungDto.power_ac9))
            {
                return boilerHeizungDto.power_ac9;
            }
            int newPower2 = newPower;
            return newPower2;
        }

        private bool checkedPowerSize(int power1, int power2)
        {
            var power = 0;
            if (power1 >= power2)
            {
                power = power1 - power2;
            }
            else
            {
                power = power2 - power1;
            }

            if (power >= 150)
            {
                return false;
            }
            return true;

        }
    }
}
