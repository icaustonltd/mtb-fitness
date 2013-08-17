using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MTBQuoteBox.Models;

using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace MTBQuoteBox.Handlers
{
    public class MTBQuoteBoxHandler : ContentHandler
    {
        public MTBQuoteBoxHandler(IRepository<MTBQuoteBoxPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}