using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Astro.Models
{
    public class AppUser : IdentityUser<int>
    {
        [PersonalData, Required, StringLength(20)]
        public string Name { get; set; }
    }
}