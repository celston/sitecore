using System;
using System.Reflection;
using Sitecore.Mvc.Presentation;
using System.Text.RegularExpressions;

namespace Sitecore.GnosisToolkit.Library.Attributes
{
    public class SitecoreFieldRawRegexSplitAttribute : SitecoreFieldRawAttribute
    {
        #region Public Properties

        public string Pattern { get; set; }

        #endregion

        #region Constructors

        public SitecoreFieldRawRegexSplitAttribute(string pattern)
        {
            Pattern = pattern;
        }

        public SitecoreFieldRawRegexSplitAttribute(string pattern, string fieldName)
        {
            Pattern = pattern;
            FieldName = fieldName;
        }

        #endregion

        #region SitecoreDataAttribute Implementation

        public override object GetValue(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, PropertyInfo pi, Rendering rendering)
        {
            string value = (string)base.GetValue(fieldNamePrefixAttribute, pi, rendering);

            return Regex.Split(value, Pattern);
        }

        #endregion
    }
}
