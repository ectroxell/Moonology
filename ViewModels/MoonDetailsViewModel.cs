using Astro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Astro.ViewModels
{
    public class MoonDetailsViewModel
    {
        public string Name { get; set; }
        public string Keywords { get; set; }
        public string DescriptionLong { get; set; }
        public string DescriptionShort { get; set; }

        //TODO: include image for each moon phase
        //public string ImgFilePath { get; set; }

        public IList<Ritual> Rituals { get; set; }
        public IList<Activity> Activities { get; set; }
    }
}
