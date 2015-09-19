using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sitecore.Data.Fields;
using Sitecore.Data.Items;

namespace Sitecore.GnosisToolkit.Library.Attributes
{
    public class SitecoreImageFieldMimeTypeAttribute : SitecoreDataAttribute
    {
        #region Public Properties

        public string FieldName { get; set; }

        #endregion

        #region Constructors

        public SitecoreImageFieldMimeTypeAttribute(string fieldName)
        {
            FieldName = fieldName;
        }

        public SitecoreImageFieldMimeTypeAttribute()
        {
        }

        #endregion

        public override object GetValue(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, System.Reflection.PropertyInfo pi, Sitecore.Mvc.Presentation.Rendering rendering)
        {
            string fieldName = ResolveFieldName(fieldNamePrefixAttribute, pi, FieldName);

            return mediaHelper.GetImageFieldMediaItemMimeType(rendering.Item, fieldName);
        }
    }
}
