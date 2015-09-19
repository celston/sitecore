using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.GnosisToolkit.Library.Attributes
{
    public class SitecoreLinkFieldUrlAttribute : SitecoreDataAttribute
    {
        public string FieldName { get; private set; }

        #region Constructors

        public SitecoreLinkFieldUrlAttribute()
        {
        }

        public SitecoreLinkFieldUrlAttribute(string fieldName)
        {
            FieldName = fieldName;
        }

        #endregion

        public override object GetValue(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, System.Reflection.PropertyInfo pi, Sitecore.Mvc.Presentation.Rendering rendering)
        {
            string fieldName = ResolveFieldName(fieldNamePrefixAttribute, pi, FieldName);
            return linksHelper.GetLinkFieldAbsoluteUrl(rendering.Item, fieldName);
        }
    }
}
