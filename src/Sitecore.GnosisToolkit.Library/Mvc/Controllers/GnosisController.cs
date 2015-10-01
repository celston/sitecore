using System;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;

using Sitecore.Mvc.Presentation;

using Sitecore.GnosisToolkit.Library.Attributes;
using Sitecore.GnosisToolkit.Library.Helpers;

namespace Sitecore.GnosisToolkit.Library.Mvc.Controllers
{
    public abstract class GnosisController : Controller
    {
        protected ItemsHelper itemsHelper = ItemsHelper.Instance;

        protected Rendering Rendering
        {
            get
            {
                return RenderingContext.Current.Rendering;
            }
        }

        protected void InitializeModel(object model)
        {
            ProcessProperties(model, model.GetType());

            foreach (Type iface in model.GetType().GetInterfaces())
            {
                ProcessProperties(model, iface);
            }
        }

        protected void ProcessProperties(object model, Type t)
        {
            SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute = GetSitecoreFieldNamePrefixAttribute(t);
            foreach (PropertyInfo pi in t.GetProperties())
            {
                foreach (SitecoreDataAttribute attribute in pi.GetCustomAttributes<SitecoreDataAttribute>())
                {
                    if (pi.GetSetMethod() == null)
                    {
                        throw new Exception(String.Format("No set method for {0}", pi.Name));
                    }

                    pi.SetValue(model, attribute.GetValue(fieldNamePrefixAttribute, pi, Rendering));
                }
            }
        }

        protected SitecoreFieldNamePrefixAttribute GetSitecoreFieldNamePrefixAttribute(Type type)
        {
            return type.GetCustomAttributes<SitecoreFieldNamePrefixAttribute>().FirstOrDefault();
        }
    }
}
