﻿namespace ShopAssistantAPI.Migrations
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
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ShopAssistantAPI.Models.ShopAssistantAPIContext context)
        {
            context.Stores.AddOrUpdate(x => x.Id,
                new Store() { Id = 1, Name = "Kaufland", Address = "Legnicka 62A, 52-204 Wrocław", Lat = 51.1211939, Lng = 16.986153 },
                new Store() { Id = 2, Name = "Tesco", Address = "Magnolia Park, Legnicka 58, 54-204 Wrocław", Lat = 51.1199009, Lng = 16.983921 },
                new Store() { Id = 3, Name = "Tesco", Address = "Długa 37/47, 50-001 Wrocław", Lat = 51.1182903, Lng = 17.010846 },
                new Store() { Id = 4, Name = "Tesco", Address = "Paprotna 7, 50-001 Wrocław", Lat = 51.1518433, Lng = 16.99133 },
                new Store() { Id = 5, Name = "Carrefour", Address = "Piotra Czajkowskiego 51, 51-171 Wrocław", Lat = 51.1406802, Lng = 17.064566 },
                new Store() { Id = 6, Name = "Carrefour", Address = "Bardzka 3, 50-001 Wrocław", Lat = 51.0821329, Lng = 17.047983 },
                new Store() { Id = 7, Name = "Carrefour", Address = "Centrum Handlowe Borek, aleja Hallera 52, 50-984 Wrocław", Lat = 51.0912814, Lng = 16.996404 });

            context.UserTypes.AddOrUpdate(x => x.Id,
                new UserType() { Id = 1, Name = "Regular User" },
                new UserType() { Id = 2, Name = "Store Manager" },
                new UserType() { Id = 3, Name = "Application Admin" });

            context.ProdCategories.AddOrUpdate(x => x.Id,
                new ProdCategory() { Id = 1, Name = "Dairy" },
                new ProdCategory() { Id = 2, Name = "Alcohol" },
                new ProdCategory() { Id = 3, Name = "Beverages" },
                new ProdCategory() { Id = 4, Name = "Chemicals" },
                new ProdCategory() { Id = 5, Name = "Animal Articles" },
                new ProdCategory() { Id = 6, Name = "Meat" },
                new ProdCategory() { Id = 7, Name = "Cosmetics" },
                new ProdCategory() { Id = 8, Name = "Kids" },
                new ProdCategory() { Id = 9, Name = "Vegetables" },
                new ProdCategory() { Id = 10, Name = "Fruits" });

            context.Products.AddOrUpdate(x => x.Id,
                new Product() { Id = 1, Name = "Milk 1l", Desc = "1l Milk", Photo = "", ProdCategoryId = 1 },
                new Product() { Id = 2, Name = "Butter", Desc = "Regular Butter", Photo = "", ProdCategoryId = 1 },
                new Product() { Id = 3, Name = "Potato", Desc = "1kg Potatoes", Photo = "", ProdCategoryId = 9 },
                new Product() { Id = 4, Name = "Soplica", Desc = "Vodka", Photo = "", ProdCategoryId = 2 },
                new Product() { Id = 5, Name = "Jack Daniels", Desc = "Whiskey", Photo = "", ProdCategoryId = 2 },
                new Product() { Id = 6, Name = "Finlandia", Desc = "Vodka", Photo = "", ProdCategoryId = 2 },
                new Product() { Id = 7, Name = "Tyskie", Desc = "Beer", Photo = "", ProdCategoryId = 2 },
                new Product() { Id = 8, Name = "RedBull 250ml", Desc = "Energy drink", Photo = "", ProdCategoryId = 3 },
                new Product() { Id = 9, Name = "Tymbark 2l", Desc = "Juice", Photo = "", ProdCategoryId = 3 },
                new Product() { Id = 10, Name = "Nałęczowianka 1.5l", Desc = "Water", Photo = "", ProdCategoryId = 3 },
                new Product() { Id = 11, Name = "Pepsi 1l", Desc = "Fizzy drink", Photo = "", ProdCategoryId = 3 },
                new Product() { Id = 12, Name = "Coca-Cola 2l", Desc = "Fizzy drink", Photo = "", ProdCategoryId = 3 },
                new Product() { Id = 13, Name = "Bref WC Power Active Ocean", Desc = "Toilet cleaning", Photo = "", ProdCategoryId = 4 },
                new Product() { Id = 14, Name = "Velvet 8rolls", Desc = "Toilet paper", Photo = "", ProdCategoryId = 4 },
                new Product() { Id = 15, Name = "Fairy", Desc = "Dish soap", Photo = "", ProdCategoryId = 4 },
                new Product() { Id = 16, Name = "Whiskas 400g", Desc = "Cat food", Photo = "", ProdCategoryId = 5 },
                new Product() { Id = 17, Name = "Kitekat with Chicken 4x 400g", Desc = "Cat food", Photo = "", ProdCategoryId = 5 },
                new Product() { Id = 18, Name = "Pedigree Vital Protection 500g", Desc = "Dog food", Photo = "", ProdCategoryId = 5 },
                new Product() { Id = 19, Name = "Pasztet Wielkopolski 131g", Desc = "Pate", Photo = "", ProdCategoryId = 6 },
                new Product() { Id = 20, Name = "Sausages 200g", Desc = "Sausages", Photo = "", ProdCategoryId = 6 },
                new Product() { Id = 21, Name = "Chicken drumstick 1kg", Desc = "Chicken", Photo = "", ProdCategoryId = 6 },
                new Product() { Id = 22, Name = "Calvin Klein Euphoria Men 100ml", Desc = "Toilet water", Photo = "", ProdCategoryId = 7 },
                new Product() { Id = 23, Name = "Soap from Aleppo", Desc = "Soap", Photo = "", ProdCategoryId = 7 },
                new Product() { Id = 24, Name = "Naturia Hair Dye", Desc = "Hair dye", Photo = "", ProdCategoryId = 7 },
                new Product() { Id = 25, Name = "Pampers Active 90pcs", Desc = "Pampers", Photo = "", ProdCategoryId = 8 },
                new Product() { Id = 26, Name = "Bambino Olive 150ml", Desc = "Baby olive", Photo = "", ProdCategoryId = 8 },
                new Product() { Id = 27, Name = "Bananas 1kg", Desc = "1kg Bananas", Photo = "", ProdCategoryId = 10 },
                new Product() { Id = 28, Name = "Kiwi 1pc", Desc = "Kiwi", Photo = "", ProdCategoryId = 10 } );

            context.Users.AddOrUpdate(
                new User() { Id = 1, Name = "Michał Biernacki", Address = "Corn Street 50", Email = "admin@shopassistant.com", Login = "mbiernacki", Password = "lubieszyszki", UserTypeId = 3 },
                new User() { Id = 2, Name = "John Doe", Address = "Potato Street 13", Email = "johndoe@tesco.pl", Login = "jdoetesco", Password = "tescoFTW", UserTypeId = 2, StoreId = 2 },
                new User() { Id = 3, Name = "Jane Doe", Address = "Potato Street 13", Email = "janedoe@gmail.com", Login = "janedoe", Password = "iLiveOnPotatoStreet", UserTypeId = 1 }
                );

            context.StoreProducts.AddOrUpdate(
                new StoreProduct() { ProdId = 1, StoreId = 1, Amount = 15, Price = 3.48M, PPQ = 3.48M, PPW = 3.48M, Weigh = 1 },
                new StoreProduct() { ProdId = 28, StoreId = 1, Amount = 100, Price = 0.89M, PPQ = 0.89M, PPW = 8.9M },
                new StoreProduct() { ProdId = 2, StoreId = 1, Amount = 13, Price = 7.52M, PPQ = 7.52M },
                new StoreProduct() { ProdId = 3, StoreId = 1, Amount = 3, Price = 5.25M, PPQ = 5.25M, PPW = 5.25M, Weigh = 1 },
                new StoreProduct() { ProdId = 4, StoreId = 1, Amount = 7, Price = 36.99M, PPQ = 36.99M },
                new StoreProduct() { ProdId = 5, StoreId = 1, Amount = 1, Price = 69.99M, PPQ = 69.99M },
                new StoreProduct() { ProdId = 6, StoreId = 1, Amount = 0, Price = 38.12M, PPQ = 38.12M },
                new StoreProduct() { ProdId = 7, StoreId = 1, Amount = 17, Price = 1.69M, PPQ = 1.69M },
                new StoreProduct() { ProdId = 8, StoreId = 1, Amount = 12, Price = 3.75M, PPQ = 3.75M },
                new StoreProduct() { ProdId = 9, StoreId = 1, Amount = 11, Price = 3.37M, PPQ = 3.37M },
                new StoreProduct() { ProdId = 10, StoreId = 1, Amount = 21, Price = 0.92M, PPQ = 0.92M },
                new StoreProduct() { ProdId = 11, StoreId = 1, Amount = 33, Price = 2.82M, PPQ = 2.82M },
                new StoreProduct() { ProdId = 12, StoreId = 1, Amount = 24, Price = 3.39M, PPQ = 3.39M },
                new StoreProduct() { ProdId = 13, StoreId = 1, Amount = 1, Price = 2.99M, PPQ = 2.99M },
                new StoreProduct() { ProdId = 14, StoreId = 1, Amount = 56, Price = 6.88M, PPQ = 6.88M },
                new StoreProduct() { ProdId = 15, StoreId = 1, Amount = 5, Price = 4.99M, PPQ = 4.99M },
                new StoreProduct() { ProdId = 16, StoreId = 1, Amount = 7, Price = 4.09M, PPQ = 4.09M },
                new StoreProduct() { ProdId = 17, StoreId = 1, Amount = 8, Price = 9.99M, PPQ = 3.33M },
                new StoreProduct() { ProdId = 18, StoreId = 1, Amount = 6, Price = 4.49M, PPQ = 4.49M },
                new StoreProduct() { ProdId = 19, StoreId = 1, Amount = 3, Price = 1.39M, PPQ = 1.39M },
                new StoreProduct() { ProdId = 20, StoreId = 1, Amount = 13, Price = 3.49M, PPQ = 3.49M },
                new StoreProduct() { ProdId = 21, StoreId = 1, Amount = 12, Price = 4.99M, PPQ = 4.99M, PPW = 4.99M, Weigh = 1 },
                new StoreProduct() { ProdId = 22, StoreId = 1, Amount = 15, Price = 125.00M, PPQ = 125.0M },
                new StoreProduct() { ProdId = 24, StoreId = 1, Amount = 15, Price = 4.89M, PPQ = 4.89M },
                new StoreProduct() { ProdId = 23, StoreId = 1, Amount = 16, Price = 23.31M, PPQ = 23.31M },
                new StoreProduct() { ProdId = 25, StoreId = 1, Amount = 27, Price = 52.99M, PPQ = 52.99M },
                new StoreProduct() { ProdId = 26, StoreId = 1, Amount = 32, Price = 6.99M, PPQ = 6.99M },
                new StoreProduct() { ProdId = 27, StoreId = 1, Amount = 87, Price = 4.89M, PPQ = 4.89M, PPW = 8.69M, Weigh = 0.4M },
                // Store 2
                new StoreProduct() { ProdId = 1, StoreId = 2, Amount = 1, Price = 3.48M, PPQ = 3.48M, PPW = 3.48M, Weigh = 1 },
                new StoreProduct() { ProdId = 28, StoreId = 2, Amount = 4, Price = 0.89M, PPQ = 0.89M, PPW = 8.9M },
                new StoreProduct() { ProdId = 2, StoreId = 2, Amount = 2, Price = 7.52M, PPQ = 7.52M },
                new StoreProduct() { ProdId = 3, StoreId = 2, Amount = 3, Price = 5.25M, PPQ = 5.25M, PPW = 5.25M, Weigh = 1 },
                new StoreProduct() { ProdId = 4, StoreId = 2, Amount = 6, Price = 36.99M, PPQ = 36.99M },
                new StoreProduct() { ProdId = 5, StoreId = 2, Amount = 7, Price = 69.99M, PPQ = 69.99M },
                new StoreProduct() { ProdId = 6, StoreId = 2, Amount = 9, Price = 38.12M, PPQ = 38.12M },
                new StoreProduct() { ProdId = 7, StoreId = 2, Amount = 1, Price = 1.69M, PPQ = 1.69M },
                new StoreProduct() { ProdId = 8, StoreId = 2, Amount = 23, Price = 3.75M, PPQ = 3.75M },
                new StoreProduct() { ProdId = 9, StoreId = 2, Amount = 12, Price = 3.37M, PPQ = 3.37M },
                new StoreProduct() { ProdId = 10, StoreId = 2, Amount = 41, Price = 0.92M, PPQ = 0.92M },
                new StoreProduct() { ProdId = 11, StoreId = 2, Amount = 15, Price = 2.82M, PPQ = 2.82M },
                new StoreProduct() { ProdId = 12, StoreId = 2, Amount = 1, Price = 3.39M, PPQ = 3.39M },
                new StoreProduct() { ProdId = 13, StoreId = 2, Amount = 2, Price = 2.99M, PPQ = 2.99M },
                new StoreProduct() { ProdId = 14, StoreId = 2, Amount = 7, Price = 6.88M, PPQ = 6.88M },
                new StoreProduct() { ProdId = 15, StoreId = 2, Amount = 5, Price = 4.99M, PPQ = 4.99M },
                new StoreProduct() { ProdId = 16, StoreId = 2, Amount = 7, Price = 4.09M, PPQ = 4.09M },
                new StoreProduct() { ProdId = 17, StoreId = 2, Amount = 8, Price = 9.99M, PPQ = 3.33M },
                new StoreProduct() { ProdId = 18, StoreId = 2, Amount = 6, Price = 4.49M, PPQ = 4.49M },
                new StoreProduct() { ProdId = 19, StoreId = 2, Amount = 3, Price = 1.39M, PPQ = 1.39M },
                new StoreProduct() { ProdId = 20, StoreId = 2, Amount = 43, Price = 3.49M, PPQ = 3.49M },
                new StoreProduct() { ProdId = 21, StoreId = 2, Amount = 5, Price = 4.99M, PPQ = 4.99M, PPW = 4.99M, Weigh = 1 },
                new StoreProduct() { ProdId = 22, StoreId = 2, Amount = 8, Price = 125.00M, PPQ = 125.0M },
                new StoreProduct() { ProdId = 24, StoreId = 2, Amount = 0, Price = 4.89M, PPQ = 4.89M },
                new StoreProduct() { ProdId = 23, StoreId = 2, Amount = 9, Price = 23.31M, PPQ = 23.31M },
                new StoreProduct() { ProdId = 25, StoreId = 2, Amount = 6, Price = 52.99M, PPQ = 52.99M },
                new StoreProduct() { ProdId = 26, StoreId = 2, Amount = 4, Price = 6.99M, PPQ = 6.99M },
                new StoreProduct() { ProdId = 27, StoreId = 2, Amount = 3, Price = 4.89M, PPQ = 4.89M, PPW = 8.69M, Weigh = 0.4M },
                // Store 3
                new StoreProduct() { ProdId = 1, StoreId = 3, Amount = 1, Price = 3.48M, PPQ = 3.48M, PPW = 3.48M, Weigh = 1 },
                new StoreProduct() { ProdId = 28, StoreId = 3, Amount = 2, Price = 0.89M, PPQ = 0.89M, PPW = 8.9M },
                new StoreProduct() { ProdId = 2, StoreId = 3, Amount = 3, Price = 7.52M, PPQ = 7.52M },
                new StoreProduct() { ProdId = 3, StoreId = 3, Amount = 4, Price = 5.25M, PPQ = 5.25M, PPW = 5.25M, Weigh = 1 },
                new StoreProduct() { ProdId = 4, StoreId = 3, Amount = 5, Price = 36.99M, PPQ = 36.99M },
                new StoreProduct() { ProdId = 5, StoreId = 3, Amount = 6, Price = 69.99M, PPQ = 69.99M },
                new StoreProduct() { ProdId = 6, StoreId = 3, Amount = 7, Price = 38.12M, PPQ = 38.12M },
                new StoreProduct() { ProdId = 7, StoreId = 3, Amount = 8, Price = 1.69M, PPQ = 1.69M },
                new StoreProduct() { ProdId = 8, StoreId = 3, Amount = 9, Price = 3.75M, PPQ = 3.75M },
                new StoreProduct() { ProdId = 9, StoreId = 3, Amount = 10, Price = 3.37M, PPQ = 3.37M },
                new StoreProduct() { ProdId = 10, StoreId = 3, Amount = 11, Price = 0.92M, PPQ = 0.92M },
                new StoreProduct() { ProdId = 11, StoreId = 3, Amount = 12, Price = 2.82M, PPQ = 2.82M },
                new StoreProduct() { ProdId = 12, StoreId = 3, Amount = 13, Price = 3.39M, PPQ = 3.39M },
                new StoreProduct() { ProdId = 13, StoreId = 3, Amount = 14, Price = 2.99M, PPQ = 2.99M },
                new StoreProduct() { ProdId = 14, StoreId = 3, Amount = 15, Price = 6.88M, PPQ = 6.88M },
                new StoreProduct() { ProdId = 15, StoreId = 3, Amount = 16, Price = 4.99M, PPQ = 4.99M },
                new StoreProduct() { ProdId = 16, StoreId = 3, Amount = 17, Price = 4.09M, PPQ = 4.09M },
                new StoreProduct() { ProdId = 17, StoreId = 3, Amount = 18, Price = 9.99M, PPQ = 3.33M },
                new StoreProduct() { ProdId = 18, StoreId = 3, Amount = 19, Price = 4.49M, PPQ = 4.49M },
                new StoreProduct() { ProdId = 19, StoreId = 3, Amount = 20, Price = 1.39M, PPQ = 1.39M },
                new StoreProduct() { ProdId = 20, StoreId = 3, Amount = 21, Price = 3.49M, PPQ = 3.49M },
                new StoreProduct() { ProdId = 21, StoreId = 3, Amount = 22, Price = 4.99M, PPQ = 4.99M, PPW = 4.99M, Weigh = 1 },
                new StoreProduct() { ProdId = 22, StoreId = 3, Amount = 23, Price = 125.00M, PPQ = 125.0M },
                new StoreProduct() { ProdId = 24, StoreId = 3, Amount = 24, Price = 4.89M, PPQ = 4.89M },
                new StoreProduct() { ProdId = 23, StoreId = 3, Amount = 25, Price = 23.31M, PPQ = 23.31M },
                new StoreProduct() { ProdId = 25, StoreId = 3, Amount = 26, Price = 52.99M, PPQ = 52.99M },
                new StoreProduct() { ProdId = 26, StoreId = 3, Amount = 27, Price = 6.99M, PPQ = 6.99M },
                new StoreProduct() { ProdId = 27, StoreId = 3, Amount = 28, Price = 4.89M, PPQ = 4.89M, PPW = 8.69M, Weigh = 0.4M },
                // Store 4
                new StoreProduct() { ProdId = 1, StoreId = 4, Amount = 100, Price = 3.48M, PPQ = 3.48M, PPW = 3.48M, Weigh = 1 },
                new StoreProduct() { ProdId = 28, StoreId = 4, Amount = 100, Price = 0.89M, PPQ = 0.89M, PPW = 8.9M },
                new StoreProduct() { ProdId = 2, StoreId = 4, Amount = 100, Price = 7.52M, PPQ = 7.52M },
                new StoreProduct() { ProdId = 3, StoreId = 4, Amount = 100, Price = 5.25M, PPQ = 5.25M, PPW = 5.25M, Weigh = 1 },
                new StoreProduct() { ProdId = 4, StoreId = 4, Amount = 100, Price = 36.99M, PPQ = 36.99M },
                new StoreProduct() { ProdId = 5, StoreId = 4, Amount = 100, Price = 69.99M, PPQ = 69.99M },
                new StoreProduct() { ProdId = 6, StoreId = 4, Amount = 100, Price = 38.12M, PPQ = 38.12M },
                new StoreProduct() { ProdId = 7, StoreId = 4, Amount = 100, Price = 1.69M, PPQ = 1.69M },
                new StoreProduct() { ProdId = 8, StoreId = 4, Amount = 100, Price = 3.75M, PPQ = 3.75M },
                new StoreProduct() { ProdId = 9, StoreId = 4, Amount = 100, Price = 3.37M, PPQ = 3.37M },
                new StoreProduct() { ProdId = 10, StoreId = 4, Amount = 100, Price = 0.92M, PPQ = 0.92M },
                new StoreProduct() { ProdId = 11, StoreId = 4, Amount = 100, Price = 2.82M, PPQ = 2.82M },
                new StoreProduct() { ProdId = 12, StoreId = 4, Amount = 100, Price = 3.39M, PPQ = 3.39M },
                new StoreProduct() { ProdId = 13, StoreId = 4, Amount = 100, Price = 2.99M, PPQ = 2.99M },
                new StoreProduct() { ProdId = 14, StoreId = 4, Amount = 100, Price = 6.88M, PPQ = 6.88M },
                new StoreProduct() { ProdId = 15, StoreId = 4, Amount = 100, Price = 4.99M, PPQ = 4.99M },
                new StoreProduct() { ProdId = 16, StoreId = 4, Amount = 100, Price = 4.09M, PPQ = 4.09M },
                new StoreProduct() { ProdId = 17, StoreId = 4, Amount = 100, Price = 9.99M, PPQ = 3.33M },
                new StoreProduct() { ProdId = 18, StoreId = 4, Amount = 100, Price = 4.49M, PPQ = 4.49M },
                new StoreProduct() { ProdId = 19, StoreId = 4, Amount = 100, Price = 1.39M, PPQ = 1.39M },
                new StoreProduct() { ProdId = 20, StoreId = 4, Amount = 100, Price = 3.49M, PPQ = 3.49M },
                new StoreProduct() { ProdId = 21, StoreId = 4, Amount = 100, Price = 4.99M, PPQ = 4.99M, PPW = 4.99M, Weigh = 1 },
                new StoreProduct() { ProdId = 22, StoreId = 4, Amount = 100, Price = 125.00M, PPQ = 125.0M },
                new StoreProduct() { ProdId = 24, StoreId = 4, Amount = 100, Price = 4.89M, PPQ = 4.89M },
                new StoreProduct() { ProdId = 23, StoreId = 4, Amount = 100, Price = 23.31M, PPQ = 23.31M },
                new StoreProduct() { ProdId = 25, StoreId = 4, Amount = 100, Price = 52.99M, PPQ = 52.99M },
                new StoreProduct() { ProdId = 26, StoreId = 4, Amount = 100, Price = 6.99M, PPQ = 6.99M },
                new StoreProduct() { ProdId = 27, StoreId = 4, Amount = 100, Price = 4.89M, PPQ = 4.89M, PPW = 8.69M, Weigh = 0.4M },
                // Store5
                new StoreProduct() { ProdId = 1, StoreId = 5, Amount = 15, Price = 3.48M, PPQ = 3.48M, PPW = 3.48M, Weigh = 1 },
                new StoreProduct() { ProdId = 28, StoreId = 5, Amount = 100, Price = 0.89M, PPQ = 0.89M, PPW = 8.9M },
                new StoreProduct() { ProdId = 2, StoreId = 5, Amount = 13, Price = 7.52M, PPQ = 7.52M },
                new StoreProduct() { ProdId = 3, StoreId = 5, Amount = 3, Price = 5.25M, PPQ = 5.25M, PPW = 5.25M, Weigh = 1 },
                new StoreProduct() { ProdId = 4, StoreId = 5, Amount = 7, Price = 36.99M, PPQ = 36.99M },
                new StoreProduct() { ProdId = 5, StoreId = 5, Amount = 1, Price = 69.99M, PPQ = 69.99M },
                new StoreProduct() { ProdId = 6, StoreId = 5, Amount = 0, Price = 38.12M, PPQ = 38.12M },
                new StoreProduct() { ProdId = 7, StoreId = 5, Amount = 17, Price = 1.69M, PPQ = 1.69M },
                new StoreProduct() { ProdId = 8, StoreId = 5, Amount = 12, Price = 3.75M, PPQ = 3.75M },
                new StoreProduct() { ProdId = 9, StoreId = 5, Amount = 11, Price = 3.37M, PPQ = 3.37M },
                new StoreProduct() { ProdId = 10, StoreId = 5, Amount = 21, Price = 0.92M, PPQ = 0.92M },
                new StoreProduct() { ProdId = 11, StoreId = 5, Amount = 33, Price = 2.82M, PPQ = 2.82M },
                new StoreProduct() { ProdId = 12, StoreId = 5, Amount = 24, Price = 3.39M, PPQ = 3.39M },
                new StoreProduct() { ProdId = 13, StoreId = 5, Amount = 1, Price = 2.99M, PPQ = 2.99M },
                new StoreProduct() { ProdId = 14, StoreId = 5, Amount = 56, Price = 6.88M, PPQ = 6.88M },
                new StoreProduct() { ProdId = 15, StoreId = 5, Amount = 5, Price = 4.99M, PPQ = 4.99M },
                new StoreProduct() { ProdId = 16, StoreId = 5, Amount = 7, Price = 4.09M, PPQ = 4.09M },
                new StoreProduct() { ProdId = 17, StoreId = 5, Amount = 8, Price = 9.99M, PPQ = 3.33M },
                new StoreProduct() { ProdId = 18, StoreId = 5, Amount = 6, Price = 4.49M, PPQ = 4.49M },
                new StoreProduct() { ProdId = 19, StoreId = 5, Amount = 3, Price = 1.39M, PPQ = 1.39M },
                new StoreProduct() { ProdId = 20, StoreId = 5, Amount = 13, Price = 3.49M, PPQ = 3.49M },
                new StoreProduct() { ProdId = 21, StoreId = 5, Amount = 12, Price = 4.99M, PPQ = 4.99M, PPW = 4.99M, Weigh = 1 },
                new StoreProduct() { ProdId = 22, StoreId = 5, Amount = 15, Price = 125.00M, PPQ = 125.0M },
                new StoreProduct() { ProdId = 24, StoreId = 5, Amount = 15, Price = 4.89M, PPQ = 4.89M },
                new StoreProduct() { ProdId = 23, StoreId = 5, Amount = 16, Price = 23.31M, PPQ = 23.31M },
                new StoreProduct() { ProdId = 25, StoreId = 5, Amount = 27, Price = 52.99M, PPQ = 52.99M },
                new StoreProduct() { ProdId = 26, StoreId = 5, Amount = 32, Price = 6.99M, PPQ = 6.99M },
                new StoreProduct() { ProdId = 27, StoreId = 5, Amount = 87, Price = 4.89M, PPQ = 4.89M, PPW = 8.69M, Weigh = 0.4M },
                // Store6
                new StoreProduct() { ProdId = 1, StoreId = 6, Amount = 115, Price = 3.48M, PPQ = 3.48M, PPW = 3.48M, Weigh = 1 },
                new StoreProduct() { ProdId = 28, StoreId = 6, Amount = 5, Price = 0.89M, PPQ = 0.89M, PPW = 8.9M },
                new StoreProduct() { ProdId = 2, StoreId = 6, Amount = 13, Price = 7.52M, PPQ = 7.52M },
                new StoreProduct() { ProdId = 3, StoreId = 6, Amount = 23, Price = 5.25M, PPQ = 5.25M, PPW = 5.25M, Weigh = 1 },
                new StoreProduct() { ProdId = 4, StoreId = 6, Amount = 3, Price = 36.99M, PPQ = 36.99M },
                new StoreProduct() { ProdId = 5, StoreId = 6, Amount = 5, Price = 69.99M, PPQ = 69.99M },
                new StoreProduct() { ProdId = 6, StoreId = 6, Amount = 63, Price = 38.12M, PPQ = 38.12M },
                new StoreProduct() { ProdId = 7, StoreId = 6, Amount = 0, Price = 1.69M, PPQ = 1.69M },
                new StoreProduct() { ProdId = 8, StoreId = 6, Amount = 132, Price = 3.75M, PPQ = 3.75M },
                new StoreProduct() { ProdId = 9, StoreId = 6, Amount = 121, Price = 3.37M, PPQ = 3.37M },
                new StoreProduct() { ProdId = 10, StoreId = 6, Amount = 121, Price = 0.92M, PPQ = 0.92M },
                new StoreProduct() { ProdId = 11, StoreId = 6, Amount = 233, Price = 2.82M, PPQ = 2.82M },
                new StoreProduct() { ProdId = 12, StoreId = 6, Amount = 24, Price = 3.39M, PPQ = 3.39M },
                new StoreProduct() { ProdId = 13, StoreId = 6, Amount = 21, Price = 2.99M, PPQ = 2.99M },
                new StoreProduct() { ProdId = 14, StoreId = 6, Amount = 56, Price = 6.88M, PPQ = 6.88M },
                new StoreProduct() { ProdId = 15, StoreId = 6, Amount = 15, Price = 4.99M, PPQ = 4.99M },
                new StoreProduct() { ProdId = 16, StoreId = 6, Amount = 27, Price = 4.09M, PPQ = 4.09M },
                new StoreProduct() { ProdId = 17, StoreId = 6, Amount = 48, Price = 9.99M, PPQ = 3.33M },
                new StoreProduct() { ProdId = 18, StoreId = 6, Amount = 86, Price = 4.49M, PPQ = 4.49M },
                new StoreProduct() { ProdId = 19, StoreId = 6, Amount = 73, Price = 1.39M, PPQ = 1.39M },
                new StoreProduct() { ProdId = 20, StoreId = 6, Amount = 133, Price = 3.49M, PPQ = 3.49M },
                new StoreProduct() { ProdId = 21, StoreId = 6, Amount = 122, Price = 4.99M, PPQ = 4.99M, PPW = 4.99M, Weigh = 1 },
                new StoreProduct() { ProdId = 22, StoreId = 6, Amount = 15, Price = 125.00M, PPQ = 125.0M },
                new StoreProduct() { ProdId = 24, StoreId = 6, Amount = 145, Price = 4.89M, PPQ = 4.89M },
                new StoreProduct() { ProdId = 23, StoreId = 6, Amount = 16, Price = 23.31M, PPQ = 23.31M },
                new StoreProduct() { ProdId = 25, StoreId = 6, Amount = 227, Price = 52.99M, PPQ = 52.99M },
                new StoreProduct() { ProdId = 26, StoreId = 6, Amount = 32, Price = 6.99M, PPQ = 6.99M },
                new StoreProduct() { ProdId = 27, StoreId = 6, Amount = 87, Price = 4.89M, PPQ = 4.89M, PPW = 8.69M, Weigh = 0.4M },
                // Store 7
                new StoreProduct() { ProdId = 1, StoreId = 7, Amount = 155, Price = 3.48M, PPQ = 3.48M, PPW = 3.48M, Weigh = 1 },
                new StoreProduct() { ProdId = 28, StoreId = 7, Amount = 100, Price = 0.89M, PPQ = 0.89M, PPW = 8.9M },
                new StoreProduct() { ProdId = 2, StoreId = 7, Amount = 132, Price = 7.52M, PPQ = 7.52M },
                new StoreProduct() { ProdId = 3, StoreId = 7, Amount = 31, Price = 5.25M, PPQ = 5.25M, PPW = 5.25M, Weigh = 1 },
                new StoreProduct() { ProdId = 4, StoreId = 7, Amount = 71, Price = 36.99M, PPQ = 36.99M },
                new StoreProduct() { ProdId = 5, StoreId = 7, Amount = 12, Price = 69.99M, PPQ = 69.99M },
                new StoreProduct() { ProdId = 6, StoreId = 7, Amount = 3, Price = 38.12M, PPQ = 38.12M },
                new StoreProduct() { ProdId = 7, StoreId = 7, Amount = 117, Price = 1.69M, PPQ = 1.69M },
                new StoreProduct() { ProdId = 8, StoreId = 7, Amount = 12, Price = 3.75M, PPQ = 3.75M },
                new StoreProduct() { ProdId = 9, StoreId = 7, Amount = 113, Price = 3.37M, PPQ = 3.37M },
                new StoreProduct() { ProdId = 10, StoreId = 7, Amount = 221, Price = 0.92M, PPQ = 0.92M },
                new StoreProduct() { ProdId = 11, StoreId = 7, Amount = 33, Price = 2.82M, PPQ = 2.82M },
                new StoreProduct() { ProdId = 12, StoreId = 7, Amount = 24, Price = 3.39M, PPQ = 3.39M },
                new StoreProduct() { ProdId = 13, StoreId = 7, Amount = 12, Price = 2.99M, PPQ = 2.99M },
                new StoreProduct() { ProdId = 14, StoreId = 7, Amount = 56, Price = 6.88M, PPQ = 6.88M },
                new StoreProduct() { ProdId = 15, StoreId = 7, Amount = 51, Price = 4.99M, PPQ = 4.99M },
                new StoreProduct() { ProdId = 16, StoreId = 7, Amount = 73, Price = 4.09M, PPQ = 4.09M },
                new StoreProduct() { ProdId = 17, StoreId = 7, Amount = 435, Price = 9.99M, PPQ = 3.33M },
                new StoreProduct() { ProdId = 18, StoreId = 7, Amount = 645, Price = 4.49M, PPQ = 4.49M },
                new StoreProduct() { ProdId = 19, StoreId = 7, Amount = 45, Price = 1.39M, PPQ = 1.39M },
                new StoreProduct() { ProdId = 20, StoreId = 7, Amount = 23, Price = 3.49M, PPQ = 3.49M },
                new StoreProduct() { ProdId = 21, StoreId = 7, Amount = 23, Price = 4.99M, PPQ = 4.99M, PPW = 4.99M, Weigh = 1 },
                new StoreProduct() { ProdId = 22, StoreId = 7, Amount = 234, Price = 125.00M, PPQ = 125.0M },
                new StoreProduct() { ProdId = 24, StoreId = 7, Amount = 1, Price = 4.89M, PPQ = 4.89M },
                new StoreProduct() { ProdId = 23, StoreId = 7, Amount = 2, Price = 23.31M, PPQ = 23.31M },
                new StoreProduct() { ProdId = 25, StoreId = 7, Amount = 237, Price = 52.99M, PPQ = 52.99M },
                new StoreProduct() { ProdId = 26, StoreId = 7, Amount = 2, Price = 6.99M, PPQ = 6.99M },
                new StoreProduct() { ProdId = 27, StoreId = 7, Amount = 34, Price = 4.89M, PPQ = 4.89M, PPW = 8.69M, Weigh = 0.4M }
                );
        }
    }
}
