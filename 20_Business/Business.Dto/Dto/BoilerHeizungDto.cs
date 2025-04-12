using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dto.Dto
{
    public class BoilerHeizungDto
    {
        public int power_ac9 { get; set; }

        public int power_grid_ac9 {get; set; }
        public int power1_grid { get; set; }
        public int power2_grid { get; set; }
        public int power3_grid { get; set; }
        public string ctrlstate { get; set; }

        public int screen_mode_flag { get; set; }
    }
}
