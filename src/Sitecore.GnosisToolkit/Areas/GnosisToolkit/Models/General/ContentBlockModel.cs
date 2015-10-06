using System;
using System.Web;

using Sitecore.GnosisToolkit.Library.Attributes;
using Sitecore.GnosisToolkit.Library.Mvc.Models;
using Sitecore.GnosisToolkit.Library.Mvc.Models.General;

namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit.Models.General
{
    public class ContentBlockModel : BaseRenderingModel, IContentBlock
    {
        public HtmlString Heading { get; set; }
        public bool ShowHeading { get; set; }
        public HtmlString Image { get; set; }
        public bool ShowImage { get; set; }
        public HtmlString Body { get; set; }
    }
}