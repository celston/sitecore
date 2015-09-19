using System;
using System.Web;

using Sitecore.GnosisToolkit.Library.Mvc.Models;
using Sitecore.GnosisToolkit.Library.Attributes;

namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit.Models.General
{
    [SitecoreFieldNamePrefix("Call to Action")]
    public class CallToActionModel : BaseRenderingModel
    {
        [SitecoreField]
        public HtmlString Heading { get; private set; }
        [SitecoreField]
        public HtmlString Image { get; private set; }
        [SitecoreField]
        public HtmlString Body { get; private set; }
        [SitecoreField]
        public HtmlString Link { get; private set; }
        [SitecoreLinkFieldUrl("Link")]
        public string LinkUrl { get; private set; }
    }
}