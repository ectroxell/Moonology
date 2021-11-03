using Astro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Astro.Data
{
    public class MoonPhaseSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any DB sets.
                if (context.MoonPhases.Any())
                {
                    return;   // DB has been seeded
                }

                MoonPhaseInfo newMoon = new MoonPhaseInfo()
                {
                    PhaseID = 1,
                    Name = "New Moon",
                    Keywords = "Set intentions",
                    DescriptionShort = "Listen to your intuition and allow new ideas to form.",
                    DescriptionLong = "The new moon is the perfect time to set intentions. At this time, it's not visible in the sky. It is sometimes called the dark moon or the hare moon. The energy of the new moon is quiet. Without the benefit of the moon's light, our ancestors rested on new moon nights. " +
                    "Use this time to go inward and reflect on your desires. Set intentions for your life. Think of these intentions as seeds. What will you cultivate during the moon cycle?"
                };
                MoonPhaseInfo waxingCrescent = new MoonPhaseInfo()
                {
                    PhaseID = 2,
                    Name = "Waxing Crescent",
                    Keywords = "Be curious",
                    DescriptionShort = "Get excited about new possibilites.",
                    DescriptionLong = null
                };
                MoonPhaseInfo firstQuarter = new MoonPhaseInfo()
                {
                    PhaseID = 3,
                    Name = "First Quarter",
                    Keywords = "Develop",
                    DescriptionShort = "Take action and build momentum.",
                    DescriptionLong = "This phase is about development. You planted your seeds on the new moon. Now it's time to help them grow! The first qurater moon can inspire you to take action, make decisions, and overcome challenges. Work towards your goals."
                };
                MoonPhaseInfo waxingGibbous = new MoonPhaseInfo()
                {
                    PhaseID = 4,
                    Name = "Waxing Gibbous",
                    Keywords = "Improve",
                    DescriptionShort = "Refine and make improvements.",
                    DescriptionLong = null
                };
                MoonPhaseInfo fullMoon = new MoonPhaseInfo()
                {
                    PhaseID = 5,
                    Name = "Full Moon",
                    Keywords = "Full expression",
                    DescriptionShort = "Celebrate your progress.",
                    DescriptionLong = "When the moon is completely illuminated, it's time to reach full expression. The full moon is the most powerful time of the moon cycle. Enjoy the full expression of life. Be fully engaged. Let the light of the moon energize you." +
                    " This is your harvest. Harvest new internal realizations. Take note of your epiphanies. Harvest external success. Enjoy the life you are creating. Celebrate. This is a powerfully healing time. Send healing blessings to others."
                };
                MoonPhaseInfo waningGibbous = new MoonPhaseInfo()
                {
                    PhaseID = 6,
                    Name = "Waning Gibbous",
                    Keywords = "Share",
                    DescriptionShort = "Reflect and teach others what you've learned.",
                    DescriptionLong = null
                };
                MoonPhaseInfo thirdQuarter = new MoonPhaseInfo()
                {
                    PhaseID = 7,
                    Name = "Third Quarter",
                    Keywords = "Release",
                    DescriptionShort = "Take stock of your life. Find room to let go.",
                    DescriptionLong = "When the moon appears smaller and becomes half-illuminated, it's time to think about releasing. The third quarter moon phase signals a time to let go. Release anything you no longer need to make room for the new! Meditate on what you've" +
                    " learned during the course of the moon cycle. Take stock of your life and notice if there are any relationships, commitments, physical objects, habits, or emotions you are ready to let go of. Letting go will free up energy that can be used during the next" +
                    " moon cycle. This is a quiet time to rest and restore."
                };
                MoonPhaseInfo waningCrescent = new MoonPhaseInfo()
                {
                    PhaseID = 8,
                    Name = "Waning Crescent",
                    Keywords = "Silence",
                    DescriptionShort = "Rest and restore - get very quiet so that you can hear your intuition.",
                    DescriptionLong = "The waning crescent phase marks the end of the lunar cycle. It is time for surrender and rest. No more action, thinking, or planning is required - just relax and trust in the process."
                };

                //add to db and save changes

                context.MoonPhases.AddRange(newMoon, waxingCrescent, firstQuarter, waxingGibbous, fullMoon, waningGibbous, thirdQuarter, waningCrescent);
                context.SaveChanges();
            }
        }
    }
}