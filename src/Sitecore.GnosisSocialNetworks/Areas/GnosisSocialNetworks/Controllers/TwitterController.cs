using System;
using System.Web.Mvc;

using Sitecore.Mvc.Presentation;

using Sitecore.GnosisSocialNetworks.Areas.GnosisSocialNetworks.Models.Twitter;
using Sitecore.GnosisToolkit.Library.Mvc.Controllers;

namespace Sitecore.GnosisSocialNetworks.Areas.GnosisSocialNetworks.Controllers
{
    public class TwitterController : BaseController
    {
        // GET: GnosisSocialNetworks/Twitter
        public ActionResult TwitterSummaryCard()
        {
            TwitterSummaryCardModel model = new TwitterSummaryCardModel();

            InitializeModel(model);

            return View(model);
        }

        public ActionResult TwitterSummaryCardWithLargeImage()
        {
            TwitterSummaryCardWithLargeImageModel model = new TwitterSummaryCardWithLargeImageModel();

            InitializeModel(model);

            return View("TwitterSummaryCard", model);
        }

        public ActionResult TwitterAppCard()
        {
            TwitterAppCardModel model = new TwitterAppCardModel();

            InitializeModel(model);

            return View(model);
        }

        public ActionResult TwitterPlayerCard()
        {
            TwitterPlayerCardModel model = new TwitterPlayerCardModel();

            InitializeModel(model);

            return View(model);
        }
    }
}