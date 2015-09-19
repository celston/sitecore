using System;
using System.Linq;
using System.Reflection;

using Sitecore.Mvc.Presentation;
using Sitecore.Data.Fields;

namespace Sitecore.GnosisToolkit.Library.Attributes
{
    public class SitecoreMultilistFieldAbsoluteUrlsAttribute : SitecoreDataAttribute
    {
        public string FieldName { get; protected set; }

        #region Constructors

        public SitecoreMultilistFieldAbsoluteUrlsAttribute()
        {
        }

        public SitecoreMultilistFieldAbsoluteUrlsAttribute(string fieldName)
        {
            FieldName = fieldName;
        }

        #endregion

        #region SitecoreDataAttribute Implementation

        public override object GetValue(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, PropertyInfo pi, Rendering rendering)
        {
            string fieldName = ResolveFieldName(fieldNamePrefixAttribute, pi, FieldName);
            MultilistField field = (MultilistField)rendering.Item.Fields[fieldName];

            if (field == null)
            {
                return new string[] { };
            }

            return field.GetItems().Select(x => linksHelper.GetItemAbsoluteUrl(x)).ToArray();
        }

        #endregion
    }
}
