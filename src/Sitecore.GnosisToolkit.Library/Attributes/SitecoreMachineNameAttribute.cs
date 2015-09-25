using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Mvc.Presentation;

namespace Sitecore.GnosisToolkit.Library.Attributes
{
    public class SitecoreMachineNameAttribute : SitecoreDataAttribute
    {
        public override object GetValue(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, PropertyInfo pi, Rendering rendering)
        {
            return itemsHelper.GetItemMachineName(rendering.Item);
        }
    }
}
