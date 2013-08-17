using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

using Orchard.ContentManagement;

namespace MTBQuoteBox.Models
{
    public class MTBQuoteBoxPart : ContentPart<MTBQuoteBoxPartRecord>
    {
        public string Author
        {
            get { return Record.Author; }
            set { Record.Author = value; }
        }

        public string MainBody
        {
            get { return Record.MainBody; }
            set { Record.MainBody = value; }
        }
    }
}