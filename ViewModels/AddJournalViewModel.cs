using Astro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Astro.ViewModels
{
    public class AddJournalViewModel
    {
        public string JournalText { get; set; }
        public MoonPhaseInfo MoonPhase { get; set; }
    }
}
