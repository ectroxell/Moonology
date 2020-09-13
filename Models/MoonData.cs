using SunCalcNet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Astro.Models
{
    public class MoonData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int PhaseID { get; set; }
        public string Illumination { get; set; }

        public MoonData(MoonIllumination cfg)
        {
            // set phase
            if (0 <= cfg.Phase && cfg.Phase < 0.1)
            {
                Name = "New Moon";
                PhaseID = 1;
            }
            if (0.1 <= cfg.Phase && cfg.Phase < 0.25)
            {
                Name = "Waxing Crescent";
                PhaseID = 2;
            }
            if (0.25 <= cfg.Phase && cfg.Phase < 0.28)
            {
                Name = "First Quarter";
                PhaseID = 3;
            }
            if (0.28 <= cfg.Phase && cfg.Phase < 0.5)
            {
                Name = "Waxing Gibbous";
                PhaseID = 4;
            }
            if (0.5 <= cfg.Phase && cfg.Phase < 0.53)
            {
                Name = "Full Moon";
                PhaseID = 5;
            }
            if (0.53 <= cfg.Phase && cfg.Phase < 0.75)
            {
                Name = "Waning Gibbous";
                PhaseID = 6;
            }
            if (0.75 <= cfg.Phase && cfg.Phase < 0.78)
            {
                Name = "Third Quarter";
                PhaseID = 7;
            }
            if (0.78 <= cfg.Phase && cfg.Phase < 1)
            {
                Name = "Waning Crescent";
                PhaseID = 8;
            }

            //set illumination
            Illumination = Convert.ToInt32(cfg.Fraction * 100).ToString() + '%';
        }

        public MoonData() { }
    }
}
