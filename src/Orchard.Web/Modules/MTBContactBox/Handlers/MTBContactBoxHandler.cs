using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MTBContactBox.Models;

using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace MTBContactBox.Handlers
{
    public class MTBContactBoxHandler : ContentHandler
    {
        public MTBContactBoxHandler(IRepository<MTBContactBoxPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}