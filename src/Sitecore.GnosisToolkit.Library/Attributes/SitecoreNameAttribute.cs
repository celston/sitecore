using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Mvc.Presentation;

namespace Sitecore.GnosisToolkit.Library.Attributes
{
    public class SitecoreNameAttribute : SitecoreDataAttribute
    {
        public override object GetValue(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, PropertyInfo pi, Rendering rendering)
        {
            return rendering.Item.Name;
        }
    }
}
