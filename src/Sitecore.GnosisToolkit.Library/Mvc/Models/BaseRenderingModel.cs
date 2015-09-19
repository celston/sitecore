using System;
using System.Linq;

using Sitecore.Mvc.Presentation;

using Sitecore.GnosisToolkit.Library.Helpers;
using System.Reflection;
using Sitecore.GnosisToolkit.Library.Attributes;

namespace Sitecore.GnosisToolkit.Library.Mvc.Models
{
    public abstract class BaseRenderingModel : IRenderingModel
    {
        #region Protected Fields

        protected readonly MediaHelper mediaHelper = MediaHelper.Instance;
        protected readonly FieldsHelper fieldsHelper = FieldsHelper.Instance;
        protected readonly ItemsHelper itemsHelper = ItemsHelper.Instance;
        protected readonly LinksHelper linksHelper = LinksHelper.Instance;
        protected Rendering currentRendering;

        #endregion

        #region Public Properties

        public Guid Id { get; private set; }
        public string MachineName { get; private set; }

        #endregion

        #region IRenderingModel Implementation

        public virtual void Initialize(Rendering rendering)
        {
            this.currentRendering = rendering;
            MachineName = itemsHelper.GetItemMachineName(rendering.Item);
            Id = rendering.Item.ID.ToGuid();
            
            SitecoreFieldNamePrefixAttribute fieldNamePrefixAttribute = this.GetType().GetCustomAttributes<SitecoreFieldNamePrefixAttribute>().FirstOrDefault();

            foreach (PropertyInfo pi in GetType().GetProperties())
            {
                foreach (SitecoreDataAttribute attribute in pi.GetCustomAttributes<SitecoreDataAttribute>())
                {
                    Sitecore.Diagnostics.Profiler.StartOperation(String.Format("Processing {0} for {1}", attribute.GetType().Name, pi.Name));
                    
                    if (pi.SetMethod == null)
                    {
                        throw new Exception(String.Format("No set method for {0}", pi.Name));
                    }
                    
                    pi.SetValue(this, attribute.GetValue(fieldNamePrefixAttribute, pi, rendering));

                    Sitecore.Diagnostics.Profiler.EndOperation(String.Format("Processing {0} for {1}", attribute.GetType().Name, pi.Name));
                }
            }
        }

        #endregion
    }
}