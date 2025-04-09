using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dto.Dto
{
    public class BoilerHeizungPowerDto
    {
        public int validForMinutes { get; set; }
        public int power { get; set; }
        public int? pidPower { get; set; }
        public int timeBoostOverride { get; set; }
        public int timeBoostValue { get; set; }
        public int legionellaBoostBlock { get; set; }
        public int batteryDischargeBlock { get; set; }
    }
}
