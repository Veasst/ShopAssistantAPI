namespace ShopAssistantAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ShopAssistantAPI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ShopAssistantAPI.Models.ShopAssistantAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShopAssistantAPI.Models.ShopAssistantAPIContext context)
        {
            context.Stores.AddOrUpdate(x => x.Id,
                new Store() { Id = 1, Name = "Biedronka", Address = "Potato Street 13", Lat = 51.23, Lng = 52.69 });

            context.UserTypes.AddOrUpdate(x => x.Id,
                new UserType() { Id = 1, Name = "Regular User" },
                new UserType() { Id = 2, Name = "Store Manager" });

            ProdCategory Dairy = new ProdCategory() { Id = 1, Name = "Dairy" };
            context.ProdCategories.AddOrUpdate(x => x.Id,
                Dairy);

            context.Products.AddOrUpdate(x => x.Id,
                new Product() { Id = 1, Name = "Milk", Desc = "2L Milk", Photo = "", ProdCategoryId = 1, ProdCategory = Dairy },
                new Product() { Id = 2, Name = "Butter", Desc = "Regular Butter", Photo = "", ProdCategoryId = 1, ProdCategory = Dairy });
        }
    }
}
