using System;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;

using Sitecore.Mvc.Presentation;

using Sitecore.GnosisToolkit.Library.Attributes;

namespace Sitecore.GnosisToolkit.Library.Mvc.Controllers
{
    public abstract class BaseController : Controller
    {
        protected Rendering Rendering
        {
            get
            {
                return RenderingContext.Current.Rendering;
            }
        }

        protected void InitializeModel(object model)
        {
            SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute = model.GetType().GetCustomAttributes<SitecoreFieldNamePrefixAttribute>().FirstOrDefault();

            foreach (PropertyInfo pi in model.GetType().GetProperties())
            {
                foreach (SitecoreDataAttribute attribute in pi.GetCustomAttributes<SitecoreDataAttribute>())
                {
                    Sitecore.Diagnostics.Profiler.StartOperation(String.Format("Processing {0} for {1}", attribute.GetType().Name, pi.Name));

                    if (pi.GetSetMethod() == null)
                    {
                        throw new Exception(String.Format("No set method for {0}", pi.Name));
                    }

                    pi.SetValue(model, attribute.GetValue(fieldNamePrefixAttribute, pi, Rendering));

                    Sitecore.Diagnostics.Profiler.EndOperation(String.Format("Processing {0} for {1}", attribute.GetType().Name, pi.Name));
                }
            }
        }
    }
}
