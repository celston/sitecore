using System;

using Sitecore.GnosisToolkit.Library.Attributes;

namespace Sitecore.GnosisSocialNetworks.Areas.GnosisSocialNetworks.Models.OpenGraph
{
    public class OpenGraphArticleModel : OpenGraphBasicModel
    {
        [SitecoreFieldRaw]
        public string ArticlePublishedTime { get; set; }
        [SitecoreFieldRaw]
        public string ArticleModifiedTime { get; set; }
        [SitecoreFieldRaw]
        public string ArticleExpirationTime { get; set; }
        [SitecoreMultilistFieldAbsoluteUrls("Article Authors")]
        public string[] ArticleAuthorUrls { get; set; }
        [SitecoreFieldRaw]
        public string ArticleSection { get; set; }
        [SitecoreFieldRawRegexSplit(@"\s*,\s*")]
        public string[] ArticleTags { get; set; }

        public bool ShowArticlePublishedTime
        {
            get { return !String.IsNullOrWhiteSpace(ArticlePublishedTime); }
        }

        public bool ShowArticleTags
        {
            get { return ArticleTags.Length > 0; }
        }

        public bool ShowAuthors
        {
            get { return ArticleAuthorUrls.Length > 0;  }
        }
    }
}