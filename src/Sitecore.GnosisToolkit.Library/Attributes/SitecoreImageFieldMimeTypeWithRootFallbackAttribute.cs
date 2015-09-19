using System;

using Sitecore.Data.Fields;
using Sitecore.Data.Items;

namespace Sitecore.GnosisToolkit.Library.Attributes
{
    public class SitecoreImageFieldMimeTypeWithRootFallbackAttribute : SitecoreDataAttribute
    {
        #region Public Properties

        public string ItemFieldName { get; protected set; }
        public string RootFieldName { get; protected set; }

        #endregion

        #region Constructors

        public SitecoreImageFieldMimeTypeWithRootFallbackAttribute()
        {
        }

        public SitecoreImageFieldMimeTypeWithRootFallbackAttribute(string sharedFieldName)
        {
            ItemFieldName = sharedFieldName;
            RootFieldName = sharedFieldName;
        }

        public SitecoreImageFieldMimeTypeWithRootFallbackAttribute(string itemFieldName, string rootFieldName)
        {
            ItemFieldName = itemFieldName;
            RootFieldName = rootFieldName;
        }

        #endregion

        public override object GetValue(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, System.Reflection.PropertyInfo pi, Sitecore.Mvc.Presentation.Rendering rendering)
        {
            string itemFieldName = ResolveFieldName(fieldNamePrefixAttribute, pi, ItemFieldName);
            string rootFieldName = ResolveFieldName(fieldNamePrefixAttribute, pi, RootFieldName);

            string result = mediaHelper.GetImageFieldMediaItemMimeType(rendering.Item, itemFieldName);
            if (String.IsNullOrWhiteSpace(result))
            {
                result = mediaHelper.GetImageFieldMediaItemMimeType(itemsHelper.RootItem, rootFieldName);
            }

            return result;
        }
    }
}
