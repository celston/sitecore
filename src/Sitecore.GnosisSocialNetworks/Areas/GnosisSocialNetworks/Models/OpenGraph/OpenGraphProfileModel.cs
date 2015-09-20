using System;

using Sitecore.GnosisToolkit.Library.Attributes;

namespace Sitecore.GnosisSocialNetworks.Areas.GnosisSocialNetworks.Models.OpenGraph
{
    public class OpenGraphProfileModel : OpenGraphBasicModel
    {
        [SitecoreFieldRaw]
        public string ProfileFirstName { get; set; }
        [SitecoreFieldRaw]
        public string ProfileLastName { get; set; }
        [SitecoreFieldRaw]
        public string ProfileUsername { get; set; }
        [SitecoreFieldRaw]
        public string ProfileGender { get; set; }
    }
}