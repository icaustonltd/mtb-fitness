using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MTBSmallCTA.Models;

using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;

namespace MTBSmallCTA.Drivers
{
    public class MTBSmallCTADriver : ContentPartDriver<MTBSmallCTAPart>
    {
        protected override DriverResult Display(MTBSmallCTAPart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_MTBSmallCTA", () => shapeHelper.Parts_MTBSmallCTA(
                Item1Title: part.Item1Title,
                Item1CSSClass: part.Item1CSSClass,
                Item2Title: part.Item2Title,
                Item2CSSClass: part.Item2CSSClass,
                Item3Title: part.Item3Title,
                Item3CSSClass: part.Item3CSSClass
                ));
        }

        protected override DriverResult Editor(MTBSmallCTAPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_MTBSmallCTA_Edit", () => shapeHelper.EditorTemplate(
                TemplateName: "Parts/MTBSmallCTA",
                Model: part,
                Prefix: Prefix));
        }

        protected override DriverResult Editor(MTBSmallCTAPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}