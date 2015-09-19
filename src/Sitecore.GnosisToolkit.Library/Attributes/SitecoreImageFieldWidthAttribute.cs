using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sitecore.Data.Fields;

namespace Sitecore.GnosisToolkit.Library.Attributes
{
    public class SitecoreImageFieldWidthAttribute : SitecoreDataAttribute
    {
        #region Public Properties

        public string FieldName { get; set; }

        #endregion

        #region Constructors

        public SitecoreImageFieldWidthAttribute(string fieldName)
        {
            FieldName = fieldName;
        }

        public SitecoreImageFieldWidthAttribute()
        {
        }

        #endregion

        public override object GetValue(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, System.Reflection.PropertyInfo pi, Sitecore.Mvc.Presentation.Rendering rendering)
        {
            string fieldName = ResolveFieldName(fieldNamePrefixAttribute, pi, FieldName);
            ImageField field = fieldsHelper.GetImageField(rendering.Item, fieldName);

            int result = 0;
            if (field != null && Int32.TryParse(field.Width, out result))
            {
                return result;
            }

            return result;
        }
    }
}
