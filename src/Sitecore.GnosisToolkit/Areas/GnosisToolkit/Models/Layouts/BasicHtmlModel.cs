using System;

using Sitecore.GnosisToolkit.Library.Mvc.Models;
using Sitecore.GnosisToolkit.Library.Attributes;

namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit.Models.Layouts
{
    public class BasicHtmlModel : BaseRenderingModel
    {
        [SitecoreImageFieldPathWithRootFallback("Favicon")]
        public string FaviconPath { get; private set; }
        [SitecoreImageFieldMimeTypeWithRootFallback("Favicon")]
        public string FaviconMimeType { get; set; }
        [SitecoreFieldRaw]
        public string HtmlTitleName { get; set; }
        [SitecoreFieldRaw]
        public string HtmlTitleSection { get; set; }
        [SitecoreFieldRaw]
        public string HtmlTitleOverride { get; set; }
        [SitecoreRootFieldRaw]
        public string HtmlTitleFormat { get; set; }
        [SitecoreFieldRaw]
        public string MetaKeywords { get; set; }
        [SitecoreFieldRaw]
        public string MetaDescription { get; set; }
        [SitecoreFieldRaw]
        public string MetaAuthor { get; set; }

        public string HtmlTitle
        {
            get
            {
                if (!String.IsNullOrWhiteSpace(HtmlTitleOverride))
                {
                    return HtmlTitleOverride;
                }

                try
                {
                    return String.Format(HtmlTitleFormat, HtmlTitleName, HtmlTitleSection);
                }
                catch (FormatException)
                {
                    return null;
                }
            }
        }

        public bool ShowFavicon
        {
            get { return !String.IsNullOrWhiteSpace(FaviconPath); }
        }

        public string Lang
        {
            get { return currentRendering.Item.Language.CultureInfo.TwoLetterISOLanguageName; }
        }

        public string CanonicalUrl
        {
            get { return linksHelper.GetItemAbsoluteUrl(currentRendering.Item); }
        }

        public bool ShowMetaKeywords
        {
            get { return !String.IsNullOrWhiteSpace(MetaKeywords); }
        }

        public bool ShowMetaDescription
        {
            get { return !String.IsNullOrWhiteSpace(MetaDescription); }
        }

        public bool ShowMetaAuthor
        {
            get { return !String.IsNullOrWhiteSpace(MetaAuthor); }
        }
    }
}