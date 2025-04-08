using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Utility.Configuration
{
    public class App_Settings
    {
        public required int TimeoutService_Seconds { get; set; } = 60;
        public required bool IsEnabled { get; set; } = true;
        public required string ApiUrlMyPV { get; set; }
        public required string ApiSerialNumberMyPV { get; set; }
        public required string ApiTokenMyPV { get; set; }
        public required string ApiUsername { get; set; }

        public required string ApiPassword { get; set; }

        public required string ApiUrl { get; set; }

    }
}
