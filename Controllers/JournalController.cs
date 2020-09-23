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
using SunCalcNet;
using SunCalcNet.Model;

namespace Astro.Controllers
{
    public class JournalController : Controller
    {
        private ApplicationDbContext context;

        private UserManager<AppUser> userManager;
        public JournalController(ApplicationDbContext dbContext, UserManager<AppUser> _userManager)
        {
            context = dbContext;
            userManager = _userManager;
        }

        public async Task<IActionResult> Index()
        {
            AppUser currentUser = await userManager.GetUserAsync(HttpContext.User);
            IList<Journal> journals = context.Journals.Where(c => c.UserID == currentUser.Id).Include(c => c.MoonPhase).ToList();
            return View(journals);
        }
        public IActionResult Add()
        {
            MoonIllumination moonIllum = MoonCalc.GetMoonIllumination(DateTime.Now.ToUniversalTime());
            MoonData currentMoonData = new MoonData(moonIllum);
            MoonPhaseInfo currentMoonPhaseInfo = context.MoonPhases.Where(c => c.PhaseID == currentMoonData.PhaseID).FirstOrDefault();
            AddJournalViewModel viewModel = new AddJournalViewModel()
            {
                MoonPhase = currentMoonPhaseInfo
            };
            
            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddJournalViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                AppUser currentUser = await userManager.GetUserAsync(HttpContext.User);
                Journal newJournal = new Journal()
                {
                    UserID = currentUser.Id,
                    Date = DateTime.Now,
                    JournalText = viewModel.JournalText,
                    MoonPhase = viewModel.MoonPhase
                };

                //add journal to database
                context.Journals.Add(newJournal);
                context.SaveChanges();

                //redirect user to index
                return Redirect("/Index");
            }
            //return user to form if invalid
            return View(viewModel);
        }
    }
}