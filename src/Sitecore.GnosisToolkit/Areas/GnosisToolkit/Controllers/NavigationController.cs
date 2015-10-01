using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Sitecore.GnosisToolkit.Areas.GnosisToolkit.Models.Navigation;
using Sitecore.GnosisToolkit.Library.Mvc.Controllers;
using Sitecore.Data.Items;

namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit.Controllers
{
    public class NavigationController : GnosisController
    {
        // GET: GnosisToolkit/Navigation
        public ActionResult PrimaryNavigation()
        {
            NavigationModel model = new NavigationModel();

            Item primaryNavigationRoot = itemsHelper.GetReferenceFieldTargetItem(itemsHelper.RootItem, "Site Primary Navigation");
            foreach (Item child in primaryNavigationRoot.Children)
            {
                NavigationItemModel navigationItem = new NavigationItemModel();

                navigationItem.Link = new HtmlString(Web.UI.WebControls.FieldRenderer.Render(child, "Navigation Item Link"));

                model.Items.Add(navigationItem);
            }

            return View(model);
        }
    }
}