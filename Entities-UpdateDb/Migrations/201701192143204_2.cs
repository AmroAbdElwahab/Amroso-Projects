namespace Entities_UpdateDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Items", name: "UnitId", newName: "UnitRecId");
            RenameIndex(table: "dbo.Items", name: "IX_UnitId", newName: "IX_UnitRecId");
            AddColumn("dbo.Purches", "VendorRecId", c => c.Int(nullable: false));
            CreateIndex("dbo.Purches", "VendorRecId");
            AddForeignKey("dbo.Purches", "VendorRecId", "dbo.Vendors", "RecId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purches", "VendorRecId", "dbo.Vendors");
            DropIndex("dbo.Purches", new[] { "VendorRecId" });
            DropColumn("dbo.Purches", "VendorRecId");
            RenameIndex(table: "dbo.Items", name: "IX_UnitRecId", newName: "IX_UnitId");
            RenameColumn(table: "dbo.Items", name: "UnitRecId", newName: "UnitId");
        }
    }
}
