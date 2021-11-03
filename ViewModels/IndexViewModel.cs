using Astro.Models;

namespace Astro.ViewModels
{
    public class IndexViewModel
    {
        public MoonData CurrentMoonData { get; set; }
        public MoonPhaseInfo MoonPhaseInfo { get; set; }
    }
}