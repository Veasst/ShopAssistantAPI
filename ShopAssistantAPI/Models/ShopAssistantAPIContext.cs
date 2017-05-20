using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShopAssistantAPI.Models
{
    public class ShopAssistantAPIContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ShopAssistantAPIContext() : base("name=ShopAssistantAPIContext")
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
        }

        public System.Data.Entity.DbSet<ShopAssistantAPI.Models.UserType> UserTypes { get; set; }

        public System.Data.Entity.DbSet<ShopAssistantAPI.Models.Store> Stores { get; set; }

        public System.Data.Entity.DbSet<ShopAssistantAPI.Models.ProdCategory> ProdCategories { get; set; }

        public System.Data.Entity.DbSet<ShopAssistantAPI.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<ShopAssistantAPI.Models.StoreProduct> StoreProducts { get; set; }

        public System.Data.Entity.DbSet<ShopAssistantAPI.Models.User> Users { get; set; }
    }
}
