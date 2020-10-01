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
                Text = "Take a meditative and cleansing bath. Fill the bath with essential oils and cleansing epsom salts."
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
            Ritual ritual8 = new Ritual()
            {
                PhaseID = 4,
                Text = "White Light Protection: Sit upright on a chair with your feet on the ground. Close your eyes and breathe deeply. As you inhale, picture pure white light being drawn down into your body through the top of your head. As you exhale, " +
                       "visualize the light filling up your body, starting at your head and slowly moving down and ending at your feet. Next, sense it expanding outwards from your heart center, pushing away negative energy as it grows. Visualize it expanding into" +
                       " an egg-shaped field, extending all around you."
            };
            Ritual ritual9 = new Ritual()
            {
                PhaseID = 2,
                Text = "It is a time for action, so go through your intentions and write down a list of practical goals that will lead you to manifesting each one. If you are unsure of where to begin, use an oracle or tarot card deck to help guide your energy."
            };
            Ritual ritual10 = new Ritual()
            {
                PhaseID = 6,
                Text = "Your insight will be heightened, so it's a powerful time for both shadow work and divination. Use the waning moon oracle card spread for guidance on what needs to be released in your life."
            };
            Ritual ritual11 = new Ritual()
            {
                PhaseID = 8,
                Text = "Smoke Purification Ritual: Light a candle and spend a few minutes grounding yourself by meditatiing or deep breathing. Light the smoke wand with the candle and slowly walk around your house. Start at the front door and move in a clockwise direction. " +
                       "As you enter each room, open all the doors and windows. Gently wave the smoke wand, allowing the smoke to get into the corners of each room. Focus your intention on driving out negative energy."
            };


            //add to db and save changes

            context.Rituals.AddRange(ritual1, ritual2, ritual3, ritual4, ritual5, ritual6, ritual7, ritual8, ritual9, ritual10, ritual11);
            context.SaveChanges();
        }
    }
}