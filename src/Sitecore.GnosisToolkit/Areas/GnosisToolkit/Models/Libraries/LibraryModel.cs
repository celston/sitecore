using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Sitecore.GnosisToolkit.Library.Attributes;

namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit.Models.Libraries
{
    public abstract class LibraryModel
    {
        [SitecoreLinkFieldUrl("Library Link")]
        public string Url { get; set; }
    }
}