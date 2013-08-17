using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

using Orchard.ContentManagement;

namespace MTBSmallCTA.Models
{
    public class MTBSmallCTAPart : ContentPart<MTBSmallCTAPartRecord>
    {
        [Required(ErrorMessage = "Item 1 Title is required")]
        [Display(Name = "Item 1 Title")]
        public string Item1Title
        {
            get { return Record.Item1Title; }
            set { Record.Item1Title = value; }
        }

        [Required(ErrorMessage = "Item 1 CSS Class is required")]
        [Display(Name = "Item 1 CSS Class")]
        public string Item1CSSClass
        {
            get { return Record.Item1CSSClass; }
            set { Record.Item1CSSClass = value; }
        }

        [Required(ErrorMessage = "Item 2 Title is required")]
        [Display(Name = "Item 2 Title")]
        public string Item2Title
        {
            get { return Record.Item2Title; }
            set { Record.Item2Title = value; }
        }

        [Required(ErrorMessage = "Item 2 CSS Class is required")]
        [Display(Name = "Item 2 CSS Class")]
        public string Item2CSSClass
        {
            get { return Record.Item2CSSClass; }
            set { Record.Item2CSSClass = value; }
        }

        [Required(ErrorMessage = "Item 3 Title is required")]
        [Display(Name = "Item 3 Title")]
        public string Item3Title
        {
            get { return Record.Item3Title; }
            set { Record.Item3Title = value; }
        }

        [Required(ErrorMessage = "Item 3 CSS Class is required")]
        [Display(Name = "Item 3 CSS Class")]
        public string Item3CSSClass
        {
            get { return Record.Item3CSSClass; }
            set { Record.Item3CSSClass = value; }
        }
    }
}