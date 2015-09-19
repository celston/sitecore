using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.GnosisToolkit.Library.Attributes
{
    public class SitecoreImageFieldAbsoluteUrlAttribute : SitecoreDataAttribute
    {
        #region Public Properties

        public string FieldName { get; set; }

        #endregion

        #region Constructors

        public SitecoreImageFieldAbsoluteUrlAttribute()
        {
        }

        public SitecoreImageFieldAbsoluteUrlAttribute(string fieldName)
        {
            FieldName = fieldName;
        }

        #endregion

        #region SitecoreDataAttribute Implementation

        public override object GetValue(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, System.Reflection.PropertyInfo pi, Sitecore.Mvc.Presentation.Rendering rendering)
        {
            string fieldName = ResolveFieldName(fieldNamePrefixAttribute, pi, FieldName);
            return mediaHelper.GetImageFieldMediaItemAbsoluteUrl(rendering.Item, fieldName);
        }

        #endregion
    }
}
