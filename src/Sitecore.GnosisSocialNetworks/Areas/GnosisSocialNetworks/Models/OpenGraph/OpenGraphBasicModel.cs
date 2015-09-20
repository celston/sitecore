using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Sitecore.GnosisToolkit.Library.Mvc.Models;
using Sitecore.GnosisToolkit.Library.Attributes;

namespace Sitecore.GnosisSocialNetworks.Areas.GnosisSocialNetworks.Models.OpenGraph
{
    [SitecoreFieldNamePrefix("Open Graph")]
    public class OpenGraphBasicModel
    {
        [SitecoreFieldRawWithRootFallback("Site Name Override", "Site Name")]
        public string SiteName { get; set; }
        [SitecoreFieldRaw]
        public string Title { get; set; }
        [SitecoreFieldRaw]
        public string Description { get; set; }
        [SitecoreImageFieldAbsoluteUrl("Image")]
        public string ImageUrl { get; set; }
        [SitecoreImageFieldHeight("Image")]
        public int ImageHeight { get; set; }
        [SitecoreImageFieldWidth("Image")]
        public int ImageWidth { get; set; }
        [SitecoreImageFieldMimeType("Image")]
        public string ImageMimeType { get; set; }
        [SitecoreFieldRaw]
        public string Determiner { get; set; }
        [SitecoreLinkFieldAbsoluteUrl("Audio")]
        public string AudioUrl { get; set; }
        [SitecoreLinkFieldAbsoluteUrl("Video")]
        public string VideoUrl { get; set; }

        public string Locale { get; set; }

        public bool ShowDescription
        {
            get { return !String.IsNullOrWhiteSpace(Description); }
        }

        public bool ShowImage
        {
            get { return !String.IsNullOrWhiteSpace(ImageUrl); }
        }
        
        public bool ShowDeterminer
        {
            get { return !String.IsNullOrWhiteSpace(Determiner); }
        }

        public bool ShowAudio
        {
            get { return !String.IsNullOrWhiteSpace(AudioUrl); }
        }

        public bool ShowVideo
        {
            get { return !String.IsNullOrWhiteSpace(VideoUrl); }
        }
    }
}