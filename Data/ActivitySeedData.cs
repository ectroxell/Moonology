using Astro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Astro.Data
{
    public class ActivitySeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>());
            
            
            // Look for any DB sets.
            if (context.Activities.Any())
            {
                return;   // DB has been seeded
            }

            Activity Activity1 = new Activity()
            {
                PhaseID = 1,
                Text = "Set intentions"
            };
            Activity Activity2 = new Activity()
            {
                PhaseID = 1,
                Text = "Quiet time"
            };
            Activity Activity3 = new Activity()
            {
                PhaseID = 1,
                Text = "Alone time"
            };
            Activity Activity4 = new Activity()
            {
                PhaseID = 1,
                Text = "Rest and recuperation"
            };
            Activity Activity5 = new Activity()
            {
                PhaseID = 1,
                Text = "Pray"
            };
            Activity Activity6 = new Activity()
            {
                PhaseID = 1,
                Text = "Meditate"
            };
            Activity Activity7 = new Activity()
            {
                PhaseID = 2,
                Text = "This is a busy time! Do any work or activies that will support your intentions."
            };
            Activity Activity8 = new Activity()
            {
                PhaseID = 2,
                Text = "Start new projects or explore new directions."
            };
            Activity Activity9 = new Activity()
            {
                PhaseID = 3,
                Text = "Accumulate"
            };
            Activity Activity10 = new Activity()
            {
                PhaseID = 3,
                Text = "Work"
            };
            Activity Activity11 = new Activity()
            {
                PhaseID = 3,
                Text = "Socialize"
            };
            Activity Activity12 = new Activity()
            {
                PhaseID = 3,
                Text = "Produce"
            };
            Activity Activity13 = new Activity()
            {
                PhaseID = 3,
                Text = "Build momentum"
            };
            Activity Activity14 = new Activity()
            {
                PhaseID = 5,
                Text = "Play, sing, dance, draw"
            };
            Activity Activity15 = new Activity()
            {
                PhaseID = 5,
                Text = "Celebrate your accomplishments, big or small, with someone you trust."
            };
            Activity Activity16 = new Activity()
            {
                PhaseID = 5,
                Text = "Share what you've discovered about yourself."
            };
            Activity Activity17 = new Activity()
            {
                PhaseID = 4,
                Text = "Review your completed goals and to-do tasks, and acknowledge the progress you have made so far."
            };
            Activity Activity18 = new Activity()
            {
                PhaseID = 5,
                Text = "Light a candle on your altar to honor your growth."
            };
            Activity Activity19 = new Activity()
            {
                PhaseID = 5,
                Text = "Cleanse your crystals in the light of the moon."
            };
            Activity Activity20 = new Activity()
            {
                PhaseID = 7,
                Text = "Cleaning"
            };
            Activity Activity21 = new Activity()
            {
                PhaseID = 7,
                Text = "Use your journal"
            };
            Activity Activity22 = new Activity()
            {
                PhaseID = 7,
                Text = "Meditating"
            };
            Activity Activity23 = new Activity()
            {
                PhaseID = 7,
                Text = "Doing nothing"
            };
            Activity Activity24 = new Activity()
            {
                PhaseID = 8,
                Text = "Doing nothing"
            };
            Activity Activity25 = new Activity()
            {
                PhaseID = 7,
                Text = "Resting"
            };
            Activity Activity26 = new Activity()
            {
                PhaseID = 2,
                Text = "Announce your intentions and goals for the new month - even if only to one trusted person - this will keep you accountable and keeps you motivated."
            };
            Activity Activity27 = new Activity()
            {
                PhaseID = 2,
                Text = "Do a quick check in to ensure that your actions and intentions are still aligned, and adjust them if necessary."
            };
            Activity Activity28 = new Activity()
            {
                PhaseID = 6,
                Text = "The waning period is associated with letting go of that which no longer serves you, so try to identify any self-limiting beliefs or fears which have been holding you back."
            };
            Activity Activity29 = new Activity()
            {
                PhaseID = 8,
                Text = "Let your mind become still and allow the universe to take over"
            };
            Activity Activity30 = new Activity()
            {
                PhaseID = 8,
                Text = "Use the rest of the moon's waning energy for purification or cleansing, to prepare yourself for the upcoming cycle"
            };
            Activity Activity31 = new Activity()
            {
                PhaseID = 8,
                Text = "De-clutter to clear out stale energy and create space for the new"
            };



            //add to db and save changes

            context.Activities.AddRange(Activity1, Activity2, Activity3, Activity4, Activity5, Activity6, Activity7, Activity8, Activity9, Activity10, Activity11, Activity12, Activity13, Activity14, Activity15, Activity16, Activity17, Activity18, Activity19, Activity20, Activity21, Activity22, Activity23, Activity24, Activity25, Activity26, Activity27, Activity28, Activity29, Activity30, Activity31);
            context.SaveChanges();
        }
    }
}