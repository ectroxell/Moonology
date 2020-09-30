using Astro.Models;

namespace Astro.ViewModels
{
    public class AddJournalViewModel
    {
        public string JournalText { get; set; }
        public MoonPhaseInfo MoonPhase { get; set; }

        public AddJournalViewModel()
        {
        }
    }
}