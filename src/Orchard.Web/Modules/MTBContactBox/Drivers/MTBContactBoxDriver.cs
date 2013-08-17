using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MTBContactBox.Models;

using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;

namespace MTBContactBox.Drivers
{
    public class MTBContactBoxDriver : ContentPartDriver<MTBContactBoxPart>
    {
        protected override DriverResult Display(MTBContactBoxPart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_MTBContactBox", () => shapeHelper.Parts_MTBContactBox(
                Title: part.Title,
                MainBody: part.MainBody
                ));
        }

        protected override DriverResult Editor(MTBContactBoxPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_MTBContactBox_Edit", () => shapeHelper.EditorTemplate(
                TemplateName: "Parts/MTBContactBox",
                Model: part,
                Prefix: Prefix));
        }

        protected override DriverResult Editor(MTBContactBoxPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}