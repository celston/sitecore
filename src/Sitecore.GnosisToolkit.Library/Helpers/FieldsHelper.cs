using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sitecore.Data.Fields;
using Sitecore.Data.Items;

namespace Sitecore.GnosisToolkit.Library.Helpers
{
    public class FieldsHelper
    {
        #region Singleton Setup

        private static readonly Lazy<FieldsHelper> lazy = new Lazy<FieldsHelper>(() =>
        {
            return new FieldsHelper();
        });

        private FieldsHelper()
        {
        }

        public static FieldsHelper Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        #endregion

        public ImageField GetImageField(Item item, string fieldName)
        {
            return (ImageField)item.Fields[fieldName];
        }

        public LinkField GetLinkField(Item item, string fieldName)
        {
            return (LinkField)item.Fields[fieldName];
        }
    }
}
