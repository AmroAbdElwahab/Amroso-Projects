namespace Entities_UpdateDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("Setup.Item", "Image", c => c.String(maxLength: 100));
            AddColumn("Setup.Unit", "Image", c => c.String(maxLength: 100));
            AddColumn("Transactions.Purch", "Image", c => c.String(maxLength: 100));
            AddColumn("Setup.Vendor", "Image", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("Setup.Vendor", "Image");
            DropColumn("Transactions.Purch", "Image");
            DropColumn("Setup.Unit", "Image");
            DropColumn("Setup.Item", "Image");
        }
    }
}
