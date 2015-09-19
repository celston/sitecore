using System;
using System.Web;

using Sitecore.GnosisToolkit.Library.Attributes;
using Sitecore.GnosisToolkit.Library.Mvc.Models;

namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit.Models.General
{
    [SitecoreFieldNamePrefix("Content Block")]
    public class ContentBlockModel : BaseRenderingModel
    {
        [SitecoreField]
        public HtmlString Heading { get; private set; }
        [SitecoreCheckboxRenderingParameter]
        public bool ShowHeading { get; private set; }
        [SitecoreField]
        public HtmlString Image { get; private set; }
        [SitecoreCheckboxRenderingParameter]
        public bool ShowImage { get; private set; }
        [SitecoreField]
        public HtmlString Body { get; private set; }
    }
}