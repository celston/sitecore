using Sitecore.GnosisToolkit.Library.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.GnosisSocialNetworks.Areas.GnosisSocialNetworks.Models.Twitter
{
    public class TwitterAppCardModel : TwitterCardModel
    {
        public override string CardType
        {
            get { return "app"; }
        }

        [SitecoreFieldRaw]
        public string AppIphoneName { get; set; }
        [SitecoreFieldRaw]
        public string AppIphoneId { get; set; }
        [SitecoreFieldRaw]
        public string AppIphoneUrl { get; set; }
        [SitecoreFieldRaw]
        public string AppIpadName { get; set; }
        [SitecoreFieldRaw]
        public string AppIpadId { get; set; }
        [SitecoreFieldRaw]
        public string AppIpadUrl { get; set; }
        [SitecoreFieldRaw]
        public string AppGooglePlayName { get; set; }
        [SitecoreFieldRaw]
        public string AppGooglePlayId { get; set; }
        [SitecoreFieldRaw]
        public string AppGooglePlayUrl { get; set; }
        
        public bool ShowAppIphoneName
        {
            get { return !String.IsNullOrWhiteSpace(AppIphoneName); }
        }

        public bool ShowAppIphoneId
        {
            get { return !String.IsNullOrWhiteSpace(AppIphoneId); }
        }

        public bool ShowAppIphoneUrl
        {
            get { return !String.IsNullOrWhiteSpace(AppIphoneUrl); }
        }

        public bool ShowAppIpadName
        {
            get { return !String.IsNullOrWhiteSpace(AppIpadName); }
        }

        public bool ShowAppIpadId
        {
            get { return !String.IsNullOrWhiteSpace(AppIpadId); }
        }

        public bool ShowAppIpadUrl
        {
            get { return !String.IsNullOrWhiteSpace(AppIpadUrl); }
        }

        public bool ShowAppGooglePlayName
        {
            get { return !String.IsNullOrWhiteSpace(AppGooglePlayName); }
        }

        public bool ShowAppGooglePlayId
        {
            get { return !String.IsNullOrWhiteSpace(AppGooglePlayId); }
        }

        public bool ShowAppGooglePlayUrl
        {
            get { return !String.IsNullOrWhiteSpace(AppGooglePlayUrl); }
        }
    }
}