using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit.Models
{
    public abstract class ItemModel : IItem
    {
        public Guid Id { get; set; }
        public string MachineName { get; set; }
    }
}