using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Sitecore.Mvc.Presentation;

namespace Sitecore.GnosisToolkit.Library.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SitecoreRootFieldRawAttribute : SitecoreDataAttribute
    {
        public string FieldName { get; protected set; }

        #region Constructors

        public SitecoreRootFieldRawAttribute()
        {
        }

        public SitecoreRootFieldRawAttribute(string fieldName)
        {
            FieldName = fieldName;
        }

        #endregion

        public override object GetValue(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, PropertyInfo pi, Rendering rendering)
        {   
            string fieldName = ResolveFieldName(fieldNamePrefixAttribute, pi, FieldName);
            return itemsHelper.RootItem[fieldName];
        }
    }
}
