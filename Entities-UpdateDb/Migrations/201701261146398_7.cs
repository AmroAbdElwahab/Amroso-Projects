namespace Entities_UpdateDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _7 : DbMigration
    {
        public override void Up()
        {
            DropIndex("Setup.Item", new[] { "Code" });
            DropIndex("Setup.Unit", new[] { "Code" });
            DropIndex("Transactions.Purch", new[] { "Code" });
            DropIndex("Setup.Vendor", new[] { "Code" });
            CreateIndex("Setup.Item", "Code", unique: true);
            CreateIndex("Setup.Unit", "Code", unique: true);
            CreateIndex("Transactions.Purch", "Code", unique: true);
            CreateIndex("Setup.Vendor", "Code", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("Setup.Vendor", new[] { "Code" });
            DropIndex("Transactions.Purch", new[] { "Code" });
            DropIndex("Setup.Unit", new[] { "Code" });
            DropIndex("Setup.Item", new[] { "Code" });
            CreateIndex("Setup.Vendor", "Code");
            CreateIndex("Transactions.Purch", "Code");
            CreateIndex("Setup.Unit", "Code");
            CreateIndex("Setup.Item", "Code");
        }
    }
}
