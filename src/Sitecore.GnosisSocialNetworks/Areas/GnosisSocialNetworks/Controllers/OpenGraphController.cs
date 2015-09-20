using System.Web.Mvc;

using Sitecore.GnosisToolkit.Library.Mvc.Controllers;
using Sitecore.GnosisSocialNetworks.Areas.GnosisSocialNetworks.Models.OpenGraph;

namespace Sitecore.GnosisSocialNetworks.Areas.GnosisSocialNetworks.Controllers
{
    public class OpenGraphController : BaseController
    {
        #region Public Methods

        // GET: GnosisSocialNetworks/OpenGraph
        public ActionResult OpenGraphBasic()
        {
            OpenGraphBasicModel model = new OpenGraphBasicModel();

            InitializeModel(model);
            InitializeOpenGraphBasicModel(model);

            return View(model);
        }

        public ActionResult OpenGraphArticle()
        {
            OpenGraphArticleModel model = new OpenGraphArticleModel();

            InitializeModel(model);
            InitializeOpenGraphBasicModel(model);

            return View(model);
        }

        public ActionResult OpenGraphProfile()
        {
            OpenGraphProfileModel model = new OpenGraphProfileModel();

            InitializeModel(model);
            InitializeOpenGraphBasicModel(model);

            return View(model);
        }

        #endregion

        #region Protected Methods

        protected void InitializeOpenGraphBasicModel(OpenGraphBasicModel model)
        {
            model.Locale = GetRenderingItemLocale();
        }

        protected string GetRenderingItemLocale()
        {
            return Rendering.Item.Language.CultureInfo.TextInfo.CultureName.Replace("-", "_");
        }

        #endregion
    }
}