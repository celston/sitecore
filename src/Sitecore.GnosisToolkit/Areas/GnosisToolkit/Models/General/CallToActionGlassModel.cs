using System;

using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit.Models.General
{
    public class CallToActionGlassModel
    {
        [SitecoreId]
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }

        public string MachineName
        {
            get { return Name.ToLower().Replace(" ", "-"); }
        }

        [SitecoreField("Call to Action Heading")]
        public virtual string Heading { get; set; }
        [SitecoreField("Call to Action Body")]
        public virtual string Body { get; set; }
        [SitecoreField("Call to Action Link")]
        public virtual Link Link { get; set; }
        [SitecoreField("Call to Action Image")]
        public virtual Image Image { get; set; }
    }
}