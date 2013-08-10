using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MTBSlider.Models;

using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace MTBSlider.Handlers
{
    public class MTBSliderHandler : ContentHandler
    {
        public MTBSliderHandler(IRepository<MTBSliderPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}