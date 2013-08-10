using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Orchard.ContentManagement.Records;

namespace MTBSlider.Models
{
    public class MTBSliderPartRecord : ContentPartRecord
    {
        public virtual string Item1ImageUrl { get; set; }
        public virtual string Item1Title { get; set; }
        public virtual string Item1Text { get; set; }

        public virtual string Item2ImageUrl { get; set; }
        public virtual string Item2Title { get; set; }
        public virtual string Item2Text { get; set; }

        public virtual string Item3ImageUrl { get; set; }
        public virtual string Item3Title { get; set; }
        public virtual string Item3Text { get; set; }

        public virtual string Item4ImageUrl { get; set; }
        public virtual string Item4Title { get; set; }
        public virtual string Item4Text { get; set; }
    }
}