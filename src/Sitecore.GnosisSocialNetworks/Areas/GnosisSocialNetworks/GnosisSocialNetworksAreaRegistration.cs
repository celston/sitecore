using System.Web.Mvc;

namespace Sitecore.GnosisSocialNetworks.Areas.GnosisSocialNetworks
{
    public class GnosisSocialNetworksAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "GnosisSocialNetworks";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "GnosisSocialNetworks_default",
                "GnosisSocialNetworks/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}