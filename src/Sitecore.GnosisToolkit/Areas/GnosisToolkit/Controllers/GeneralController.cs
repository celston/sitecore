using System;
using System.Web.Mvc;

using Sitecore.Mvc.Presentation;
using Glass.Mapper.Sc;

using Sitecore.GnosisToolkit.Areas.GnosisToolkit.Models.General;
using Sitecore.GnosisToolkit.Library.Mvc.Controllers;

namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit.Controllers
{
    public class GeneralController : BaseController
    {
        public ActionResult CallToAction()
        {
            CallToActionModel model = new CallToActionModel();

            InitializeModel(model);

            return View(model);
        }

        public ActionResult CallToActionGlass()
        {
            SitecoreContext sitecoreContext = new SitecoreContext();

            CallToActionGlassModel model = sitecoreContext.GetItem<CallToActionGlassModel>(RenderingContext.Current.Rendering.Item.ID.ToGuid());

            return View(model);
        }
    }
}