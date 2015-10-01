using Sitecore.GnosisToolkit.Library.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit.Models.Navigation
{
    public class NavigationItemModel
    {
        [SitecoreField("Navigation Item Link")]
        public HtmlString Link { get; set; }
        public bool IsSeparator { get; set; }
        public bool IsInActiveTree { get; set; }
    }
}