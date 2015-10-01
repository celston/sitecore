using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Sitecore.GnosisToolkit.Areas.GnosisToolkit.Models.Libraries;
using Sitecore.GnosisToolkit.Library.Helpers;
using Sitecore.Data.Items;
using Sitecore.GnosisToolkit.Library.Mvc.Controllers;

namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit.Controllers
{
    public class LibrariesController : GnosisController
    {
        #region Private Fields

        private readonly ItemsHelper itemsHelper = ItemsHelper.Instance;
        private readonly FieldsHelper fieldsHelper = FieldsHelper.Instance;
        private readonly LinksHelper linksHelper = LinksHelper.Instance;

        #endregion

        #region Public Methods

        public ActionResult SiteCssLibraries()
        {
            SiteCssLibrariesModel model = new SiteCssLibrariesModel();

            model.Urls = GetSiteLibrariesUrls("Site CSS Libraries");

            return View(model);
        }

        
        public ActionResult SiteJavaScriptLibraries()
        {
            SiteJavaScriptLibrariesModel model = new SiteJavaScriptLibrariesModel();

            model.Urls = GetSiteLibrariesUrls("Site JavaScript Libraries");

            return View(model);
        }

        public ActionResult JavaScriptLibrary()
        {
            JavaScriptLibraryModel model = new JavaScriptLibraryModel();

            InitializeModel(model);

            return View(model);
        }

        public ActionResult CssLibrary()
        {
            CssLibraryModel model = new CssLibraryModel();

            InitializeModel(model);

            return View(model);
        }

        #endregion

        #region Protected Methods

        protected string[] GetSiteLibrariesUrls(string fieldName)
        {
            Item[] libraries = fieldsHelper.GetMultilistFieldItems(itemsHelper.RootItem, fieldName);

            return libraries.Select(x => linksHelper.GetLinkFieldUrl(x, "Library Link")).ToArray();
        }

        #endregion
    }
}