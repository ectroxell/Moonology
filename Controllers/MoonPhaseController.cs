using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Astro.Data;
using Astro.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
        public IActionResult Index()
        {
            return View();
        }
    }
}
