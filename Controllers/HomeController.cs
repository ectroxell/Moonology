using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Astro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SunCalcNet;
using SunCalcNet.Model;

namespace Astro.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            MoonIllumination moonIllum = MoonCalc.GetMoonIllumination(DateTime.UtcNow);

            MoonData currentMoonData = new MoonData()
            {
                Phase = moonIllum.Phase.ToString(),
                Illumination = moonIllum.Fraction.ToString()
            }; 
            
            

            return View(currentMoonData);
        }

        
    }
}
