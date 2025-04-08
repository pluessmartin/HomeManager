using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Entities
{
    public class ElectricMeterData : Base
    {
        public DateTime Date { get; set; }

        public double Temperatur { get; set; }
        public double HighRatePowerGeneratedL1 { get; set; }

        public double HighRatePowerGeneratedL2 { get; set; }

        public double HighRatePowerGeneratedL3 { get; set; }

        public double HighRatePowerGeneratedSum { get; set; }

        public double HighRatePowerConsumedL1 { get; set; }

        public double HighRatePowerConsumedL2 { get; set; }

        public double HighRatePowerConsumedL3 { get; set; }

        public double HighRatePowerConsumedSum { get; set; }

        public double LowerRatePowerGeneratedL1 { get; set; }

        public double LowerRatePowerGeneratedL2 { get; set; }

        public double LowerRatePowerGeneratedL3 { get; set; }

        public double LowerRatePowerGeneratedSum { get; set; }

        public double LowerRatePowerConsumedL1 { get; set; }

        public double LowerRatePowerConsumedL2 { get; set; }

        public double LowerRatePowerConsumedL3 { get; set; }

        public double LowerRatePowerConsumedSum { get; set; }


        public double CurrentPowerL1 { get; set; }

        public double CurrentPowerL2 { get; set; }

        public double CurrentPowerL3 { get; set; }

        public double CurrentPowerSum { get; set; }

        public double ProducePowerSum { get; set; }
    }
}
