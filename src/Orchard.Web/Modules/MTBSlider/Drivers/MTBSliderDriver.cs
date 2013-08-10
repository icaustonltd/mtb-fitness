using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MTBSlider.Models;

using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;

namespace MTBSlider.Drivers
{
    public class MTBSliderDriver : ContentPartDriver<MTBSliderPart>
    {
        protected override DriverResult Display(MTBSliderPart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_MTBSlider", () => shapeHelper.Parts_MTBSlider(
                Image1Source: part.Item1ImageUrl,
                Item1Title: part.Item1Title,
                Item1Text: part.Item1ImageUrl,
                Image2Source: part.Item2ImageUrl,
                Item2Title: part.Item2Title,
                Item2Text: part.Item2Text,
                Image3Source: part.Item3ImageUrl,
                Item3Title: part.Item3Title,
                Item3Text: part.Item3Text,
                Image4Source: part.Item4ImageUrl,
                Item4Title: part.Item4Title,
                Item4Text: part.Item4Text
                ));
        }

        protected override DriverResult Editor(MTBSliderPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_MTBSlider_Edit", () => shapeHelper.EditorTemplate(
                TemplateName: "Parts/MTBSlider",
                Model: part,
                Prefix: Prefix));
        }

        protected override DriverResult Editor(MTBSliderPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}