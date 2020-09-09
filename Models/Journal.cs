using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Astro.Models
{
    public class Journal
    {
        public int UserID { get; set; }
        public MoonPhaseInfo MoonPhase { get; set; }
        public MoonData MoonData { get; set; }
        public string JournalText { get; set; }
    }
}
