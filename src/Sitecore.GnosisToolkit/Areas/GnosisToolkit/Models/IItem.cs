using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sitecore.GnosisToolkit.Library.Attributes;

namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit.Models
{
    public interface IItem
    {
        [SitecoreId]
        Guid Id { get; set; }
        [SitecoreMachineName]
        string MachineName { get; set; }
    }
}
