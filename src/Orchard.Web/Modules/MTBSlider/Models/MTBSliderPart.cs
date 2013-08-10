using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

using Orchard.ContentManagement;

namespace MTBSlider.Models
{
    public class MTBSliderPart : ContentPart<MTBSliderPartRecord>
    {
        [Required(ErrorMessage="An Image is required for item 1")]
        [Display(Name="Item 1 Image Url")]
        public string Item1ImageUrl
        {
            get { return Record.Item1ImageUrl;  }
            set { Record.Item1ImageUrl = value;  }
        }

        [Required]
        [Display(Name = "Item 1 Title")]
        public string Item1Title
        {
            get { return Record.Item1Title; }
            set { Record.Item1Title = value; }
        }

        [Required]
        [Display(Name = "Item 1 Text")]
        public string Item1Text
        {
            get { return Record.Item1Text; }
            set { Record.Item1Text = value; }
        }

        [Required(ErrorMessage = "An Image is required for item 2")]
        [Display(Name = "Item 2 Image Url")]
        public string Item2ImageUrl
        {
            get { return Record.Item2ImageUrl; }
            set { Record.Item2ImageUrl = value; }
        }

        [Required]
        [Display(Name = "Item 2 Title")]
        public string Item2Title
        {
            get { return Record.Item2Title; }
            set { Record.Item2Title = value; }
        }

        [Required]
        [Display(Name = "Item 2 Text")]
        public string Item2Text
        {
            get { return Record.Item2Text; }
            set { Record.Item2Text = value; }
        }

        [Required(ErrorMessage = "An Image is required for item 3")]
        [Display(Name = "Item 3 Image Url")]
        public string Item3ImageUrl
        {
            get { return Record.Item3ImageUrl; }
            set { Record.Item3ImageUrl = value; }
        }

        [Required]
        [Display(Name = "Item 3 Title")]
        public string Item3Title
        {
            get { return Record.Item3Title; }
            set { Record.Item3Title = value; }
        }

        [Required]
        [Display(Name = "Item 3 Text")]
        public string Item3Text
        {
            get { return Record.Item3Text; }
            set { Record.Item3Text = value; }
        }

        [Required(ErrorMessage = "An Image is required for item 4")]
        [Display(Name = "Item 4 Image Url")]
        public string Item4ImageUrl
        {
            get { return Record.Item4ImageUrl; }
            set { Record.Item4ImageUrl = value; }
        }

        [Required]
        [Display(Name = "Item 4 Title")]
        public string Item4Title
        {
            get { return Record.Item4Title; }
            set { Record.Item4Title = value; }
        }

        [Required]
        [Display(Name = "Item 4 Text")]
        public string Item4Text
        {
            get { return Record.Item4Text; }
            set { Record.Item4Text = value; }
        }
    }
}