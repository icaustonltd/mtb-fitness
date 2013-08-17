using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Orchard.ContentManagement.Records;

namespace MTBSmallCTA.Models
{
    public class MTBSmallCTAPartRecord : ContentPartRecord
    {
        public virtual string Item1Title { get; set; }
        public virtual string Item1CSSClass { get; set; }

        public virtual string Item2Title { get; set; }
        public virtual string Item2CSSClass { get; set; }

        public virtual string Item3Title { get; set; }
        public virtual string Item3CSSClass { get; set; }
    }
}