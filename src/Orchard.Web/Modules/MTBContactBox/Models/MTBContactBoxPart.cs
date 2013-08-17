using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

using Orchard.ContentManagement;

namespace MTBContactBox.Models

{
    public class MTBContactBoxPart : ContentPart<MTBContactBoxPartRecord>
    {
        public string Title
        {
            get { return Record.Title; }
            set { Record.Title = value; }
        }

        public string MainBody
        {
            get { return Record.MainBody; }
            set { Record.MainBody = value; }
        }
    }
}