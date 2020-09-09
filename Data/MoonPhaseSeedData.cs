using Astro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                    "Use this time to go inward and reflect on your desires. Set intentions for your life. Think of these intentions as seeds. What will you cultivate during the moon cycle?",
                    Activities = new List<string>()
                    {
                        "Set intentions",
                        "Queit tine",
                        "Alone time",
                        "Rest and recuperation",
                        "Pray",
                        "Meditate"
                    },
                    Rituals = "Go through your previous new moon intentions and write the ones that you are still hoping to fulfill on a fresh sheet of paper, along with this month's new moon intentions. Give your wishes to the moon. Write a letter to the moon telling" +
                    "her all about your hopes, dreams, goals, and intentions. Don't forget to say thank you!"
                };
                MoonPhaseInfo waxingCrescent = new MoonPhaseInfo()
                {
                    PhaseID = 2,
                    Name = "Waxing Crescent",
                    Keywords = "Be curious",
                    DescriptionShort = "Get excited about new possibilites.",
                    DescriptionLong = null,
                    Activities = null,
                    Rituals = null
                };
                MoonPhaseInfo firstQuarter = new MoonPhaseInfo()
                {
                    PhaseID = 3,
                    Name = "First Quarter",
                    Keywords = "Develop",
                    DescriptionShort = "Take action and build momentum.",
                    DescriptionLong = "This phase is about development. You planted your seeds on the new moon. Now it's time to help them grow! The first qurater moon can inspire you to take action, make decisions, and overcome challenges. Work towards your goals.",
                    Activities = new List<string>()
                    {
                        "This is a busy time! Do any work or activies that will support your intentions.",
                        "Accumulate",
                        "Work",
                        "Socialize",
                        "Produce",
                        "Build Momentum"
                    },
                    Rituals = "Say your intentions aloud while looking in the mirror. Imagine that you've achieved them. Create a feeling of gratitude as an energetic match for your intentions."
                };
                MoonPhaseInfo waxingGibbous = new MoonPhaseInfo()
                {
                    PhaseID = 4,
                    Name = "Waxing Gibbous",
                    Keywords = "Improve",
                    DescriptionShort = "Refine and make improvements.",
                    DescriptionLong = null,
                    Activities = null,
                    Rituals = null
                };
                MoonPhaseInfo fullMoon = new MoonPhaseInfo()
                {
                    PhaseID = 5,
                    Name = "Full Moon",
                    Keywords = "Full expression",
                    DescriptionShort = "Celebrate your progress.",
                    DescriptionLong = "When the moon is completely illuminated, it's time to reach full expression. The full moon is the most powerful time of the moon cycle. Enjoy the full expression of life. Be fully engaged. Let the light of the moon energize you." +
                    "This is your harvest. Harvest new internal realizations. Take note of your epiphanies. Harvest external success. Enjoy the life you are creating. Celebrate. This is a powerfully healing time. Send healing blessings to others.",
                    Activities = new List<string>()
                    {
                        "Play, sing, dance, draw",
                        "Celebrate your accomplishments, big or small, with someone you trust",
                        "Share what you've discovered about yourself",
                        "Light a candle on your altar to honor your growth",
                        "Cleanse your crystals in the light of the moon"
                        
                    },
                    Rituals = "Bathe in the moonlight. Allow the healing light of the moon to nurture and invigorate you. Take a meditative and cleansing bath. Fill the bath with essential oils and cleansing Epsom salts. Meditate on your affirmations. Meditate on what you" +
                    "will let go of in the next phase."
                };
                MoonPhaseInfo waningGibbous = new MoonPhaseInfo()
                {
                    PhaseID = 6,
                    Name = "Waning Gibbous",
                    Keywords = "Share",
                    DescriptionShort = "Reflect and teach others what you've learned.",
                    DescriptionLong = null,
                    Activities = null,
                    Rituals = null
                };
                MoonPhaseInfo thirdQuarter = new MoonPhaseInfo()
                {
                    PhaseID = 7,
                    Name = "Third Quarter",
                    Keywords = "Release",
                    DescriptionShort = "Take stock of your life. Find room to let go.",
                    DescriptionLong = "When the moon appears smaller and becomes half-illuminated, it's time to think about releasing. The third quarter moon phase signals a time to let go. Release anything you no longer need to make room for the new! Meditate on what you've" +
                    "learned during the course of the moon cycle. Take stock of your life and notivce if there are any relationships, commitments, physical objects, habits, or emotions you are ready to let go of. Letting go will free up energy that can be used during the next" +
                    "moon cycle. This is a quiet time to rest and restore.",
                    Activities = new List<string>()
                    {
                        "Cleaning",
                        "Use your journal",
                        "Meditating",
                        "Doing nothing",
                        "Resting"
                    },
                    Rituals = "On a piece of paper, write down what you are ready to release. Burn the paper in a safe way. Say aloud what you are releasing as you watch the paper burn. When the paper has finished burning, breathe in a cleansing breath and smile."
                };
                MoonPhaseInfo waningCrescent = new MoonPhaseInfo()
                {
                    PhaseID = 8,
                    Name = "Waning Crescent",
                    Keywords = "Silence",
                    DescriptionShort = "Rest and restore - get very quiet so that you can hear your intuition.",
                    Activities = null,
                    Rituals = null
                };

                //add to db and save changes

                context.MoonPhases.AddRange(newMoon, waxingCrescent, firstQuarter, waxingGibbous, fullMoon, waningGibbous, thirdQuarter, waningCrescent);
                context.SaveChanges();
            }
        }
    }
}
