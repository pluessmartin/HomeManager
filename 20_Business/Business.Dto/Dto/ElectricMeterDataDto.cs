using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dto.Dto
{
    public class ElectricMeterDataDto
    {
        public Guid id { get; set; }
        public DateTime date { get; set; }

        public double temperatur { get; set; }
        public double highRatePowerGeneratedL1 { get; set; }

        public double highRatePowerGeneratedL2 { get; set; }

        public double highRatePowerGeneratedL3 { get; set; }

        public double highRatePowerGeneratedSum { get; set; }

        public double powerGeneratedSum { get; set; }

        public double highRatePowerConsumedL1 { get; set; }

        public double highRatePowerConsumedL2 { get; set; }

        public double highRatePowerConsumedL3 { get; set; }

        public double highRatePowerConsumedSum { get; set; }

        public double powerConsumedSum { get; set; }

        public double lowerRatePowerGeneratedL1 { get; set; }

        public double lowerRatePowerGeneratedL2 { get; set; }

        public double lowerRatePowerGeneratedL3 { get; set; }

        public double lowerRatePowerGeneratedSum { get; set; }

        public double lowerRatePowerConsumedL1 { get; set; }

        public double lowerRatePowerConsumedL2 { get; set; }

        public double lowerRatePowerConsumedL3 { get; set; }

        public double lowerRatePowerConsumedSum { get; set; }

        public double currentPowerL1 { get; set; }

        public double currentPowerL2 { get; set; }

        public double currentPowerL3 { get; set; }

        public double currentPowerSum { get; set; }

        public double producePowerSum { get; set; }

    }
}
