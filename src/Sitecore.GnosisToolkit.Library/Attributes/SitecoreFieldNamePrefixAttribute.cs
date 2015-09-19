using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.GnosisToolkit.Library.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SitecoreFieldNamePrefixAttribute : Attribute
    {
        public string FieldNamePrefix { get; private set; }

        public SitecoreFieldNamePrefixAttribute(string fieldNamePrefix)
        {
            FieldNamePrefix = fieldNamePrefix;
        }
    }
}
