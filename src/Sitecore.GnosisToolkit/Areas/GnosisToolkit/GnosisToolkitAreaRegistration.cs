using System.Web.Mvc;

namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit
{
    public class GnosisToolkitAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "GnosisToolkit";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "GnosisToolkit_default",
                "GnosisToolkit/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}