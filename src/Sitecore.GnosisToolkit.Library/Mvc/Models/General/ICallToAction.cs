using System;
using System.Web;

using Sitecore.GnosisToolkit.Library.Attributes;

namespace Sitecore.GnosisToolkit.Library.Models.General
{
    [SitecoreFieldNamePrefix("Call to Action")]
    public interface ICallToAction
    {
        [SitecoreField]
        HtmlString Heading { get; set; }
        [SitecoreField]
        HtmlString Image { get; set; }
        [SitecoreField]
        HtmlString Body { get; set; }
        [SitecoreField]
        HtmlString Link { get; set; }
        [SitecoreLinkFieldUrl("Link")]
        string LinkUrl { get; set; }
        [SitecoreLinkFieldTarget("Link")]
        string LinkTarget { get; set; }
    }
}
