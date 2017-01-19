namespace Entities_UpdateDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        RecId = c.Int(nullable: false, identity: true),
                        UnitId = c.Int(nullable: false),
                        Code = c.String(maxLength: 20),
                        Name = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.RecId)
                .ForeignKey("dbo.Units", t => t.UnitId, cascadeDelete: true)
                .Index(t => t.UnitId);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        RecId = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 20),
                        Name = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.RecId);
            
            CreateTable(
                "dbo.PurchItems",
                c => new
                    {
                        ParentRecId = c.Int(nullable: false),
                        ChiledRecId = c.Int(nullable: false),
                        Qty = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.ParentRecId, t.ChiledRecId })
                .ForeignKey("dbo.Items", t => t.ChiledRecId, cascadeDelete: true)
                .ForeignKey("dbo.Purches", t => t.ParentRecId, cascadeDelete: true)
                .Index(t => t.ParentRecId)
                .Index(t => t.ChiledRecId);
            
            CreateTable(
                "dbo.Purches",
                c => new
                    {
                        RecId = c.Int(nullable: false, identity: true),
                        Month = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        Code = c.String(maxLength: 20),
                        Name = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.RecId);
            
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        RecId = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Code = c.String(maxLength: 20),
                        Name = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.RecId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchItems", "ParentRecId", "dbo.Purches");
            DropForeignKey("dbo.PurchItems", "ChiledRecId", "dbo.Items");
            DropForeignKey("dbo.Items", "UnitId", "dbo.Units");
            DropIndex("dbo.PurchItems", new[] { "ChiledRecId" });
            DropIndex("dbo.PurchItems", new[] { "ParentRecId" });
            DropIndex("dbo.Items", new[] { "UnitId" });
            DropTable("dbo.Vendors");
            DropTable("dbo.Purches");
            DropTable("dbo.PurchItems");
            DropTable("dbo.Units");
            DropTable("dbo.Items");
        }
    }
}
