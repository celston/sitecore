using System;

using Sitecore.GnosisToolkit.Library.Attributes;

namespace Sitecore.GnosisSocialNetworks.Areas.GnosisSocialNetworks.Models.Facebook
{
    [SitecoreFieldNamePrefix("Facebook")]
    public class FacebookAppIdModel
    {
        [SitecoreFieldRawWithRootFallback]
        public string ApplicationId { get; set; }
    }
}