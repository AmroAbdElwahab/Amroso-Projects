namespace Entities_UpdateDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("Transactions.Purch", "Date", c => c.DateTime(nullable: false));
            AddColumn("Transactions.Purch", "Description", c => c.String(maxLength: 150));
            AddColumn("Transactions.Purch", "Status", c => c.Int(nullable: false));
            CreateIndex("Setup.Item", "Code");
            CreateIndex("Setup.Unit", "Code");
            CreateIndex("Transactions.Purch", "Code");
            CreateIndex("Setup.Vendor", "Code");
            DropColumn("Transactions.Purch", "Month");
            DropColumn("Transactions.Purch", "Year");
            DropColumn("Transactions.Purch", "Name");
            DropColumn("Transactions.Purch", "Image");
        }
        
        public override void Down()
        {
            AddColumn("Transactions.Purch", "Image", c => c.String(maxLength: 100));
            AddColumn("Transactions.Purch", "Name", c => c.String(maxLength: 150));
            AddColumn("Transactions.Purch", "Year", c => c.Int(nullable: false));
            AddColumn("Transactions.Purch", "Month", c => c.Int(nullable: false));
            DropIndex("Setup.Vendor", new[] { "Code" });
            DropIndex("Transactions.Purch", new[] { "Code" });
            DropIndex("Setup.Unit", new[] { "Code" });
            DropIndex("Setup.Item", new[] { "Code" });
            DropColumn("Transactions.Purch", "Status");
            DropColumn("Transactions.Purch", "Description");
            DropColumn("Transactions.Purch", "Date");
        }
    }
}
