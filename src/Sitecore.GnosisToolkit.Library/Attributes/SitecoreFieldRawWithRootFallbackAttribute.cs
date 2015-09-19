using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.GnosisToolkit.Library.Attributes
{
    public class SitecoreFieldRawWithRootFallbackAttribute : SitecoreDataAttribute
    {
        public string ItemFieldName { get; set; }
        public string RootFieldName { get; set; }

        public SitecoreFieldRawWithRootFallbackAttribute()
        {
        }

        public SitecoreFieldRawWithRootFallbackAttribute(string sharedFieldName)
        {
            ItemFieldName = sharedFieldName;
            RootFieldName = sharedFieldName;
        }

        public SitecoreFieldRawWithRootFallbackAttribute(string itemFieldName, string rootFieldName)
        {
            ItemFieldName = itemFieldName;
            RootFieldName = rootFieldName;
        }

        public override object GetValue(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, System.Reflection.PropertyInfo pi, Sitecore.Mvc.Presentation.Rendering rendering)
        {
            string itemFieldName = ResolveFieldName(fieldNamePrefixAttribute, pi, ItemFieldName);
            string rootFieldName = ResolveFieldName(fieldNamePrefixAttribute, pi, RootFieldName);

            string value = rendering.Item[itemFieldName];
            if (String.IsNullOrWhiteSpace(value))
            {
                value = itemsHelper.RootItem[rootFieldName];
            }

            return value;
        }
    }
}
