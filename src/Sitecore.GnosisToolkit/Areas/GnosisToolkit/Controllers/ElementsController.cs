using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Sitecore.GnosisToolkit.Areas.GnosisToolkit.Models.Elements;
using Sitecore.Mvc.Presentation;

namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit.Controllers
{
    public class ElementsController : Controller
    {
        // GET: GnosisToolkit/Elements
        public ActionResult Div()
        {
            ElementModel model = new ElementModel();

            model.Class = RenderingContext.Current.Rendering.Parameters["Element Class"];

            return View(model);
        }
    }
}