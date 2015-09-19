using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Sitecore.GnosisToolkit.Library.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SitecoreFieldAttribute : SitecoreDataAttribute
    {
        public string FieldName { get; private set; }

        #region Constructors

        public SitecoreFieldAttribute()
        {
        }

        public SitecoreFieldAttribute(string fieldName)
        {
            FieldName = fieldName;
        }

        #endregion

        public override object GetValue(SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute, System.Reflection.PropertyInfo pi, Sitecore.Mvc.Presentation.Rendering rendering)
        {
            string fieldName = ResolveFieldName(fieldNamePrefixAttribute, pi, FieldName);
            return new HtmlString(Sitecore.Web.UI.WebControls.FieldRenderer.Render(rendering.Item, fieldName));
        }
    }
}
