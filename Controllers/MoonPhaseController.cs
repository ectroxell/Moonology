using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Astro.Data;
using Astro.Models;
using Astro.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Astro.Controllers
{
    public class MoonPhaseController : Controller
    {
        private ApplicationDbContext context;

        private UserManager<AppUser> userManager;

        public MoonPhaseController(ApplicationDbContext dbContext, UserManager<AppUser> _userManager)
        {
            context = dbContext;
            userManager = _userManager;
        }
        // GET: /<controller>/
        public IActionResult Index(int id)
        {
            MoonPhaseInfo moonPhase = context.MoonPhases.Where(c => c.PhaseID == id).FirstOrDefault();
            IList<Ritual> rituals = context.Rituals.Where(c => c.PhaseID == moonPhase.PhaseID).ToList();
            IList<Activity> activities = context.Activities.Where(c => c.PhaseID == moonPhase.PhaseID).ToList();
            MoonDetailsViewModel viewModel = new MoonDetailsViewModel() {
                Keywords = moonPhase.Keywords,
                Name = moonPhase.Name,
                DescriptionShort = moonPhase.DescriptionShort,
                DescriptionLong = moonPhase.DescriptionLong,
                Activities = null,
                Rituals = null
            };
            if (rituals.Count > 0)
            {
                viewModel.Rituals = rituals;
            }
            if (activities.Count > 0)
            {
                viewModel.Activities = activities;
            }
            

            return View(viewModel);
        }
    }
}
