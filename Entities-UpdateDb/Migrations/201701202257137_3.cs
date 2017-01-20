namespace Entities_UpdateDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Items", newName: "Item");
            RenameTable(name: "dbo.Units", newName: "Unit");
            RenameTable(name: "dbo.PurchItems", newName: "PurchItem");
            RenameTable(name: "dbo.Purches", newName: "Purch");
            RenameTable(name: "dbo.Vendors", newName: "Vendor");
            MoveTable(name: "dbo.Item", newSchema: "Setup");
            MoveTable(name: "dbo.Unit", newSchema: "Setup");
            MoveTable(name: "dbo.PurchItem", newSchema: "Transactions");
            MoveTable(name: "dbo.Purch", newSchema: "Transactions");
            MoveTable(name: "dbo.Vendor", newSchema: "Setup");
        }
        
        public override void Down()
        {
            MoveTable(name: "Setup.Vendor", newSchema: "dbo");
            MoveTable(name: "Transactions.Purch", newSchema: "dbo");
            MoveTable(name: "Transactions.PurchItem", newSchema: "dbo");
            MoveTable(name: "Setup.Unit", newSchema: "dbo");
            MoveTable(name: "Setup.Item", newSchema: "dbo");
            RenameTable(name: "dbo.Vendor", newName: "Vendors");
            RenameTable(name: "dbo.Purch", newName: "Purches");
            RenameTable(name: "dbo.PurchItem", newName: "PurchItems");
            RenameTable(name: "dbo.Unit", newName: "Units");
            RenameTable(name: "dbo.Item", newName: "Items");
        }
    }
}
