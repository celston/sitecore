﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using Sitecore.Data.Items;

namespace Sitecore.GnosisToolkit.Library.Helpers
{
    public class ItemsHelper
    {
        private readonly Lazy<Item> lazyRootItem;
        
        #region Singleton Setup

        private readonly static Lazy<ItemsHelper> lazy = new Lazy<ItemsHelper>(() =>
        {
            return new ItemsHelper();
        });

        private ItemsHelper()
        {
            lazyRootItem = new Lazy<Item>(() =>
            {
                return Sitecore.Context.Database.GetItem(Sitecore.Context.Site.RootPath);
            });
        }

        public static ItemsHelper Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        #endregion

        public Item RootItem
        {
            get
            {
                return lazyRootItem.Value;
            }
        }

        public string GetItemMachineName(Item item)
        {
            Regex regex = new Regex("[^a-z0-9]+");

            return regex.Replace(item.Name.ToLower(), "-");
        }
    }
}
