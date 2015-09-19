using System;

namespace Sitecore.GnosisToolkit.Library.Attributes
{
    public class SitecoreCheckboxRenderingParameterAttribute : SitecoreDataAttribute
    {
        #region Public Properties

        public string FieldName { get; set; }

        #endregion

        #region Constructors

        public SitecoreCheckboxRenderingParameterAttribute()
        {
        }

        public SitecoreCheckboxRenderingParameterAttribute(string fieldName)
        {
            FieldName = fieldName;
        }

        #endregion

        #region SitecoreDataAttribute Implementation

        public override object GetValue(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, System.Reflection.PropertyInfo pi, Sitecore.Mvc.Presentation.Rendering rendering)
        {
            string fieldName = ResolveFieldName(fieldNamePrefixAttribute, pi, FieldName);
            return rendering.Parameters[fieldName] == "1";
        }

        #endregion
    }
}
