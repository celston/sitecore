using System;
using System.Reflection;

using Sitecore.Mvc.Presentation;
using Sitecore.GnosisToolkit.Library.Helpers;
using System.Text.RegularExpressions;

namespace Sitecore.GnosisToolkit.Library.Attributes
{
    public abstract class SitecoreDataAttribute : Attribute
    {
        protected readonly LinksHelper linksHelper = LinksHelper.Instance;
        protected readonly ItemsHelper itemsHelper = ItemsHelper.Instance;
        protected readonly MediaHelper mediaHelper = MediaHelper.Instance;
        protected readonly FieldsHelper fieldsHelper = FieldsHelper.Instance;
        
        public abstract object GetValue(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, PropertyInfo pi, Rendering rendering);

        protected string ResolveFieldName(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, PropertyInfo pi, string fieldName)
        {
            if (fieldNamePrefixAttribute == null || String.IsNullOrWhiteSpace(fieldNamePrefixAttribute.FieldNamePrefix))
            {
                if (String.IsNullOrWhiteSpace(fieldName))
                {
                    return SplitCamelCase(pi.Name);
                }

                return fieldName;
            }

            if (String.IsNullOrWhiteSpace(fieldName))
            {
                return String.Format("{0} {1}", fieldNamePrefixAttribute.FieldNamePrefix, SplitCamelCase(pi.Name));
            }

            return String.Format("{0} {1}", fieldNamePrefixAttribute.FieldNamePrefix, fieldName);
        }

        protected string SplitCamelCase(string input)
        {
            return String.Join(" ", Regex.Split(input, "(?<!(^|[A-Z]))(?=[A-Z])|(?<!^)(?=[A-Z][a-z])"));
        }
    }
}
