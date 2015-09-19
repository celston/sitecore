using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Resources.Media;

namespace Sitecore.GnosisToolkit.Library.Helpers
{
    public class MediaHelper
    {
        #region Singleton Setup

        private readonly static Lazy<MediaHelper> lazy = new Lazy<MediaHelper>(() =>
        {
            return new MediaHelper();
        });

        private MediaHelper()
        {
        }

        public static MediaHelper Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        #endregion

        #region Protected Fields

        protected readonly FieldsHelper fieldsHelper = FieldsHelper.Instance;

        #endregion

        #region Public Methods

        public string GetMediaLinkFieldUrl(LinkField field)
        {
            if (field.TargetItem == null)
            {
                return null;
            }

            return Sitecore.Resources.Media.MediaManager.GetMediaUrl(field.TargetItem);
        }

        public string GetImageFieldMediaItemPath(Item item, string fieldName)
        {
            ImageField field = fieldsHelper.GetImageField(item, fieldName);
            if (field == null || field.MediaItem == null)
            {
                return null;
            }

            string result = MediaManager.GetMediaUrl(field.MediaItem);

            return result;
        }

        public string GetImageFieldMediaItemAbsoluteUrl(Item item, string fieldName)
        {
            ImageField field = fieldsHelper.GetImageField(item, fieldName);
            if (field == null || field.MediaItem == null)
            {
                return null;
            }

            string result = MediaManager.GetMediaUrl(field.MediaItem, BuildAbsoluteUrlMediaUrlOptions());
            
            return result;
        }

        public MediaItem GetImageFieldMediaItem(Item item, string fieldName)
        {
            ImageField imageField = fieldsHelper.GetImageField(item, fieldName);
            if (imageField == null || imageField.MediaItem == null)
            {
                return null;
            }

            return new MediaItem(imageField.MediaItem);
        }

        public string GetImageFieldMediaItemMimeType(Item item, string fieldName)
        {
            MediaItem mediaItem = GetImageFieldMediaItem(item, fieldName);
            if (mediaItem == null)
            {
                return null;
            }

            return mediaItem.MimeType;
        }

        public string GetMediaLinkFieldAbsoluteUrl(LinkField field)
        {
            if (field.TargetItem == null)
            {
                return null;
            }
            
            return Sitecore.Resources.Media.MediaManager.GetMediaUrl(field.TargetItem, BuildAbsoluteUrlMediaUrlOptions());
        }

        public MediaUrlOptions BuildAbsoluteUrlMediaUrlOptions()
        {
            return new MediaUrlOptions
            {
                AlwaysIncludeServerUrl = true
            };
        }

        #endregion

        
    }
}
