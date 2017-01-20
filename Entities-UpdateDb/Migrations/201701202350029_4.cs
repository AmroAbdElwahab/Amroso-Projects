namespace Entities_UpdateDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Setup.Item",
                c => new
                    {
                        RecId = c.Int(nullable: false, identity: true),
                        UnitRecId = c.Int(nullable: false),
                        Code = c.String(maxLength: 20),
                        Name = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.RecId)
                .ForeignKey("Setup.Unit", t => t.UnitRecId, cascadeDelete: true)
                .Index(t => t.UnitRecId);
            
            CreateTable(
                "Setup.Unit",
                c => new
                    {
                        RecId = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 20),
                        Name = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.RecId);
            
            CreateTable(
                "Transactions.PurchItem",
                c => new
                    {
                        ParentRecId = c.Int(nullable: false),
                        ChiledRecId = c.Int(nullable: false),
                        Qty = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.ParentRecId, t.ChiledRecId })
                .ForeignKey("Setup.Item", t => t.ChiledRecId, cascadeDelete: true)
                .ForeignKey("Transactions.Purch", t => t.ParentRecId, cascadeDelete: true)
                .Index(t => t.ParentRecId)
                .Index(t => t.ChiledRecId);
            
            CreateTable(
                "Transactions.Purch",
                c => new
                    {
                        RecId = c.Int(nullable: false, identity: true),
                        Month = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        VendorRecId = c.Int(nullable: false),
                        Code = c.String(maxLength: 20),
                        Name = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.RecId)
                .ForeignKey("Setup.Vendor", t => t.VendorRecId, cascadeDelete: true)
                .Index(t => t.VendorRecId);
            
            CreateTable(
                "Setup.Vendor",
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
            DropForeignKey("Transactions.PurchItem", "ParentRecId", "Transactions.Purch");
            DropForeignKey("Transactions.Purch", "VendorRecId", "Setup.Vendor");
            DropForeignKey("Transactions.PurchItem", "ChiledRecId", "Setup.Item");
            DropForeignKey("Setup.Item", "UnitRecId", "Setup.Unit");
            DropIndex("Transactions.Purch", new[] { "VendorRecId" });
            DropIndex("Transactions.PurchItem", new[] { "ChiledRecId" });
            DropIndex("Transactions.PurchItem", new[] { "ParentRecId" });
            DropIndex("Setup.Item", new[] { "UnitRecId" });
            DropTable("Setup.Vendor");
            DropTable("Transactions.Purch");
            DropTable("Transactions.PurchItem");
            DropTable("Setup.Unit");
            DropTable("Setup.Item");
        }
    }
}
