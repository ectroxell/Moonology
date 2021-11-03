using Astro.Data;
using Astro.Models;
using Astro.ViewModels;
using Microsoft.AspNetCore.Mvc;
using SunCalcNet;
using SunCalcNet.Model;
using System;
using System.Linq;

namespace Astro.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext context;

        public HomeController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            MoonIllumination moonIllum = MoonCalc.GetMoonIllumination(DateTime.Now.ToUniversalTime());
            MoonData currentMoonData = new MoonData(moonIllum);
            MoonPhaseInfo currentMoonPhaseInfo = context.MoonPhases.Where(c => c.PhaseID == currentMoonData.PhaseID).FirstOrDefault();
            IndexViewModel viewModel = new IndexViewModel()
            {
                CurrentMoonData = currentMoonData,
                MoonPhaseInfo = currentMoonPhaseInfo
            };

            return View(viewModel);
        }
    }
}