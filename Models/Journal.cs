﻿using System;

namespace Astro.Models
{
    public class Journal
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int UserID { get; set; }
        public MoonPhaseInfo MoonPhase { get; set; }
        public string JournalText { get; set; }

    }
}