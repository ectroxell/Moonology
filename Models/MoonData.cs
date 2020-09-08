using SunCalcNet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Astro.Models
{
    public class MoonData
    {
        public string Phase { get; set; }
        public int PhaseID { get; set; }
        public string Illumination { get; set; }

        public MoonData(MoonIllumination cfg)
        {
            // set phase
            if (cfg.Phase == 0)
            {
                Phase = "New Moon";
                PhaseID = 1;
            }
            if (0 < cfg.Phase && cfg.Phase > 0.25)
            {
                Phase = "Waxing Crescent";
                PhaseID = 2;
            }
            if (cfg.Phase == 0.25)
            {
                Phase = "First Quarter";
                PhaseID = 3;
            }
            if (0.25 < cfg.Phase && cfg.Phase > 0.5)
            {
                Phase = "Waxing Gibbous";
                PhaseID = 4;
            }
            if (cfg.Phase == 0.5)
            {
                Phase = "Full Moon";
                PhaseID = 5;
            }
            if (0.5 < cfg.Phase && cfg.Phase > 0.75)
            {
                Phase = "Waning Gibbous";
                PhaseID = 6;
            }
            if (cfg.Phase == 0.75)
            {
                Phase = "Last Quarter";
                PhaseID = 7;
            }
            if (0.75 < cfg.Phase && cfg.Phase > 1)
            {
                Phase = "Waning Crescent";
                PhaseID = 8;
            }

            //set illumination
            Illumination = (cfg.Fraction * 100).ToString() + '%';
        }
    }
}
