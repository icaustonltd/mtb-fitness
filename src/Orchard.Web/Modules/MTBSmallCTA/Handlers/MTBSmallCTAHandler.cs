using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MTBSmallCTA.Models;

using Orchard.Data;
using Orchard.ContentManagement.Handlers;

namespace MTBSmallCTA.Handlers
{
    public class MTBSmallCTAHandler : ContentHandler
    {
        public MTBSmallCTAHandler(IRepository<MTBSmallCTAPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}