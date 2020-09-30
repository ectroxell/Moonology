using Astro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Astro.Data
{
    public class RitualSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>());
            // Look for any DB sets.
            if (context.Rituals.Any())
            {
                return;   // DB has been seeded
            }

            Ritual ritual1 = new Ritual()
            {
                PhaseID = 1,
                Text = "Go through your previous new moon intentions and write the ones that you are still hoping to fulfill on a fresh sheet of paper, along with this month's new moon intentions. Give your wishes to the moon. Write a letter to the moon telling" +
                        " her all about your hopes, dreams, goals, and intentions. Don't forget to say thank you!"
            };
            Ritual ritual2 = new Ritual()
            {
                PhaseID = 3,
                Text = "Say your intentions aloud while looking in the mirror. Imagine that you've achieved them. Create a feeling of gratitude as an energetic match for your intentions."
            };
            Ritual ritual3 = new Ritual()
            {
                PhaseID = 5,
                Text = "Bathe in the moonlight. Allow the healing light of the moon to nurture and invigorate you."
            };
            Ritual ritual4 = new Ritual()
            {
                PhaseID = 5,
                Text = "Take a meditative and cleansing bath.Fill the bath with essential oils and cleansing Epsom salts."
            };
            Ritual ritual5 = new Ritual()
            {
                PhaseID = 5,
                Text = "Meditate on your affirmations."
            };
            Ritual ritual6 = new Ritual()
            {
                PhaseID = 5,
                Text = "Meditate on what you will let go of in the next moon cycle."
            };
            Ritual ritual7 = new Ritual()
            {
                PhaseID = 7,
                Text = "On a piece of paper, write down what you are ready to release. Burn the paper in a safe way. Say aloud what you are releasing as you watch the paper burn. When the paper has finished burning," +
                       " breathe in a cleansing breath and smile."
            };

            //add to db and save changes

            context.Rituals.AddRange(ritual1, ritual2, ritual3, ritual4, ritual5, ritual6, ritual7);
            context.SaveChanges();
        }
    }
}