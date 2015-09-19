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
    public class SitecoreFieldRawAttribute : SitecoreDataAttribute
    {
        public string FieldName { get; protected set; }

        #region Constructors

        public SitecoreFieldRawAttribute()
        {
        }

        public SitecoreFieldRawAttribute(string fieldName)
        {
            FieldName = fieldName;
        }

        #endregion

        public override object GetValue(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, PropertyInfo pi, Rendering rendering)
        {   
            string fieldName = ResolveFieldName(fieldNamePrefixAttribute, pi, FieldName);
            return rendering.Item[fieldName];
        }
    }
}
