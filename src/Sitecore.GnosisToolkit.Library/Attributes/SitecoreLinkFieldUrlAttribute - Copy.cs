using Sitecore.Data.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.GnosisToolkit.Library.Attributes
{
    public class SitecoreLinkFieldTargetAttribute : SitecoreDataAttribute
    {
        public string FieldName { get; private set; }

        #region Constructors

        public SitecoreLinkFieldTargetAttribute()
        {
        }

        public SitecoreLinkFieldTargetAttribute(string fieldName)
        {
            FieldName = fieldName;
        }

        #endregion

        public override object GetValue(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, System.Reflection.PropertyInfo pi, Sitecore.Mvc.Presentation.Rendering rendering)
        {
            string fieldName = ResolveFieldName(fieldNamePrefixAttribute, pi, FieldName);

            LinkField field = fieldsHelper.GetLinkField(rendering.Item, fieldName);

            return field.Target;
        }
    }
}
