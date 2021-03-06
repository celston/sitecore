﻿using System;
using System.Web;
using System.Web.Mvc;

using Sitecore.Data.Items;
using Sitecore.GnosisToolkit.Areas.GnosisToolkit.Models.Navigation;
using Sitecore.GnosisToolkit.Library.Mvc.Controllers;

namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit.Controllers
{
    public class ExamplesController : GnosisController
    {
        // GET: GnosisToolkit/Examples
        public ActionResult BootstrapNavbarExample()
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

        public ActionResult BootstrapTabsExample()
        {
            return View();
        }

        public ActionResult Bootstrap363RowExample()
        {
            return View();
        }

        public ActionResult JqueryUiAccordionExample()
        {
            return View();
        }
    }
}