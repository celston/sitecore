using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit.Models.Navigation
{
    public class NavigationModel
    {
        public List<NavigationItemModel> Items { get; set; }

        public NavigationModel()
        {
            Items = new List<NavigationItemModel>();
        }
    }
}