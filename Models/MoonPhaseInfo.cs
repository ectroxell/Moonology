using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Astro.Models
{
    public class MoonPhaseInfo
    {
        public int PhaseID { get; set; }
        public string Name { get; set; }
        public string Keywords { get; set; }
        public string DescriptionShort { get; set; }
        public string DescriptionLong { get; set; }
        public List<string> Activities { get; set; }
        public string Rituals { get; set; }
    }
}
