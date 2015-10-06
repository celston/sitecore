using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

using Sitecore.GnosisToolkit.Library.Attributes;

namespace Sitecore.GnosisToolkit.Library.Mvc.Models.General
{
    [SitecoreFieldNamePrefix("Content Block")]
    public interface IContentBlock
    {
        [SitecoreField]
        HtmlString Heading { get; set; }
        [SitecoreCheckboxRenderingParameter]
        bool ShowHeading { get; set; }
        [SitecoreField]
        HtmlString Image { get; set; }
        [SitecoreCheckboxRenderingParameter]
        bool ShowImage { get; set; }
        [SitecoreField]
        HtmlString Body { get; set; }
    }
}
