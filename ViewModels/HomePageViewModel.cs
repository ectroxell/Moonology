using Astro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Astro.ViewModels
{
    public class HomePageViewModel
    {
        public MoonData CurrentMoonData { get; set; }
        public MoonPhaseInfo MoonPhaseInfo { get; set; }
    }
}
