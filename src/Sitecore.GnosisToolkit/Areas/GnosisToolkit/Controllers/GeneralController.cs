using System;
using System.Web.Mvc;

using Sitecore.Mvc.Presentation;

using Sitecore.GnosisToolkit.Areas.GnosisToolkit.Models.General;
using Sitecore.GnosisToolkit.Library.Mvc.Controllers;

namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit.Controllers
{
    public class GeneralController : GnosisController
    {
        public ActionResult CallToAction()
        {
            CallToActionModel model = new CallToActionModel();

            InitializeModel(model);

            return View(model);
        }
    }
}