using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Orchard.ContentManagement.Records;

namespace MTBContactBox.Models
{
    public class MTBContactBoxPartRecord : ContentPartRecord
    {
        public virtual string Title { get; set; }
        public virtual string MainBody { get; set; }
    }
}