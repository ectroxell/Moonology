﻿using Astro.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Astro.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public DbSet<MoonPhaseInfo> MoonPhases { get; set; }
        public override DbSet<AppUser> Users { get; set; }
        public DbSet<Ritual> Rituals { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Journal> Journals { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //}
    }
}