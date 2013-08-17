using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MTBQuoteBox.Models;

using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;

namespace MTBQuoteBox.Drivers
{
    public class MTBQuoteBoxDriver : ContentPartDriver<MTBQuoteBoxPart>
    {
        protected override DriverResult Display(MTBQuoteBoxPart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_MTBQuoteBox", () => shapeHelper.Parts_MTBQuoteBox(
                Author: part.Author,
                MainBody: part.MainBody
                ));
        }

        protected override DriverResult Editor(MTBQuoteBoxPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_MTBQuoteBox_Edit", () => shapeHelper.EditorTemplate(
                TemplateName: "Parts/MTBQuoteBox",
                Model: part,
                Prefix: Prefix));
        }

        protected override DriverResult Editor(MTBQuoteBoxPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}