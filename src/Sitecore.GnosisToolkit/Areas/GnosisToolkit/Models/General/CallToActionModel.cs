using System;
using System.Web;

using Sitecore.GnosisToolkit.Library.Mvc.Models;
using Sitecore.GnosisToolkit.Library.Attributes;

namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit.Models.General
{
    [SitecoreFieldNamePrefix("Call to Action")]
    public class CallToActionModel
    {
        [SitecoreId]
        public Guid Id { get; set; }
        [SitecoreMachineName]
        public string MachineName { get; set; }

        [SitecoreField]
        public HtmlString Heading { get; set; }
        [SitecoreField]
        public HtmlString Image { get; set; }
        [SitecoreField]
        public HtmlString Body { get; set; }
        [SitecoreField]
        public HtmlString Link { get; set; }
        [SitecoreLinkFieldUrl("Link")]
        public string LinkUrl { get; set; }
    }
}