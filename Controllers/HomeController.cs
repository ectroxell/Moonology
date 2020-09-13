using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Astro.Data;
using Astro.Models;
using Astro.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SunCalcNet;
using SunCalcNet.Model;

namespace Astro.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext context;

        private UserManager<AppUser> userManager;

        public HomeController(ApplicationDbContext dbContext, UserManager<AppUser> _userManager)
        {
            context = dbContext;
            userManager = _userManager;
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
