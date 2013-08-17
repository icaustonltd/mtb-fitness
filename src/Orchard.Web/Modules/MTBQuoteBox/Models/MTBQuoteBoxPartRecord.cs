using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Orchard.ContentManagement.Records;

namespace MTBQuoteBox.Models
{
    public class MTBQuoteBoxPartRecord : ContentPartRecord
    {
        public virtual string Author { get; set; }
        public virtual string MainBody { get; set; }
    }
}