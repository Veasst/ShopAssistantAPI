namespace ShopAssistantAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProdCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Desc = c.String(),
                        ProdCategoryId = c.Int(nullable: false),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProdCategories", t => t.ProdCategoryId, cascadeDelete: true)
                .Index(t => t.ProdCategoryId);
            
            CreateTable(
                "dbo.StoreProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StoreId = c.Int(nullable: false),
                        ProdId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weigh = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PPQ = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PPW = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProdId, cascadeDelete: true)
                .ForeignKey("dbo.Stores", t => t.StoreId, cascadeDelete: true)
                .Index(t => t.StoreId)
                .Index(t => t.ProdId);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Lat = c.Double(nullable: false),
                        Lng = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        UserTypeId = c.Int(nullable: false),
                        StoreId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stores", t => t.StoreId)
                .ForeignKey("dbo.UserTypes", t => t.UserTypeId, cascadeDelete: true)
                .Index(t => t.UserTypeId)
                .Index(t => t.StoreId);
            
            CreateTable(
                "dbo.UserTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserTypeId", "dbo.UserTypes");
            DropForeignKey("dbo.Users", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.StoreProducts", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.StoreProducts", "ProdId", "dbo.Products");
            DropForeignKey("dbo.Products", "ProdCategoryId", "dbo.ProdCategories");
            DropIndex("dbo.Users", new[] { "StoreId" });
            DropIndex("dbo.Users", new[] { "UserTypeId" });
            DropIndex("dbo.StoreProducts", new[] { "ProdId" });
            DropIndex("dbo.StoreProducts", new[] { "StoreId" });
            DropIndex("dbo.Products", new[] { "ProdCategoryId" });
            DropTable("dbo.UserTypes");
            DropTable("dbo.Users");
            DropTable("dbo.Stores");
            DropTable("dbo.StoreProducts");
            DropTable("dbo.Products");
            DropTable("dbo.ProdCategories");
        }
    }
}
