using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using Sitecore.Data.Fields;
using Sitecore.Resources.Media;

namespace Sitecore.GnosisSocialNetworks.Areas.GnosisSocialNetworks.Models.Twitter
{
    public class TwitterSummaryCardWithLargeImageModel : TwitterSummaryCardModel
    {
        public override string CardType
        {
            get
            {
                return "summary_large_image";
            }
        }

        protected override bool CreatorApplicable
        {
            get
            {
                return true;
            }
        }
    }
}