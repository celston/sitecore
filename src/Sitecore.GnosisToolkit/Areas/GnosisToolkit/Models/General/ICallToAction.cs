using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit.Models.General
{
    [SitecoreType(TemplateName = "Call to Action Base")]
    public interface ICallToAction
    {
        [SitecoreField("Call to Action Heading")]
        string Heading { get; set; }
    }
}
