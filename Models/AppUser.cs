using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Astro.Models
{
    public class AppUser : IdentityUser<int>
    {
        [PersonalData, Required, StringLength(20)]
        public string Name { get; set; }

        
    }
}

