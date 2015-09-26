using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sitecore.GnosisToolkit.Library.Attributes;


namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit.Models.General
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
    }
}
