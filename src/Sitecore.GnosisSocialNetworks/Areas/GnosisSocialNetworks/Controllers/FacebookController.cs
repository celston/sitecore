using System;
using System.Web.Mvc;

using Sitecore.GnosisToolkit.Library.Mvc.Controllers;

using Sitecore.GnosisSocialNetworks.Areas.GnosisSocialNetworks.Models.Facebook;

namespace Sitecore.GnosisSocialNetworks.Areas.GnosisSocialNetworks.Controllers
{
    public class FacebookController : BaseController
    {
        // GET: GnosisSocialNetworks/Facebook
        public ActionResult FacebookAppId()
        {
            FacebookAppIdModel model = new FacebookAppIdModel();

            InitializeModel(model);

            return View(model);
        }
    }
}