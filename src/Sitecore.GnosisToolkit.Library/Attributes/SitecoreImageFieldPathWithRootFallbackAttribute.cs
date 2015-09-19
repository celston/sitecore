using Sitecore.Data.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.GnosisToolkit.Library.Attributes
{
    public class SitecoreImageFieldPathWithRootFallbackAttribute : SitecoreDataAttribute
    {
        #region Public Properties

        public string ItemFieldName { get; protected set; }
        public string RootFieldName { get; protected set; }

        #endregion

        #region Constructors

        public SitecoreImageFieldPathWithRootFallbackAttribute()
        {
        }

        public SitecoreImageFieldPathWithRootFallbackAttribute(string sharedFieldName)
        {
            ItemFieldName = sharedFieldName;
            RootFieldName = sharedFieldName;
        }

        public SitecoreImageFieldPathWithRootFallbackAttribute(string itemFieldName, string rootFieldName)
        {
            ItemFieldName = itemFieldName;
            RootFieldName = rootFieldName;
        }

        #endregion

        #region SitecoreDataAttribute Implementation

        public override object GetValue(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, System.Reflection.PropertyInfo pi, Sitecore.Mvc.Presentation.Rendering rendering)
        {
            string itemFieldName = ResolveFieldName(fieldNamePrefixAttribute, pi, ItemFieldName);
            string rootFieldName = ResolveFieldName(fieldNamePrefixAttribute, pi, RootFieldName);

            string result = mediaHelper.GetImageFieldMediaItemAbsoluteUrl(rendering.Item, itemFieldName);
            if (String.IsNullOrWhiteSpace(result))
            {
                result = mediaHelper.GetImageFieldMediaItemPath(itemsHelper.RootItem, rootFieldName);
            }

            return result;
        }

        #endregion
    }
}
