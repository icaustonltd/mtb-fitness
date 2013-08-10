using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Orchard.UI.Resources;

namespace MTBSlider
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();
            manifest.DefineScript("nivoslider").SetUrl("jquery.nivo.slider.js");
        }
    }
}