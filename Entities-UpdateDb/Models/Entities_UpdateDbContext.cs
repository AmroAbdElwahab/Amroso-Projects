using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Entities_UpdateDb.Models
{
    public class Entities_UpdateDbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Entities_UpdateDbContext() : base("name=Entities_UpdateDbContext")
        {
        }

        public System.Data.Entity.DbSet<PriceList.Models.Item> Items { get; set; }

        public System.Data.Entity.DbSet<PriceList.Models.Unit> Units { get; set; }

        public System.Data.Entity.DbSet<PriceList.Models.Vendor> Vendors { get; set; }

        public System.Data.Entity.DbSet<PriceList.Models.Purch> Purchs { get; set; }

        public System.Data.Entity.DbSet<PriceList.Models.PurchItem> PurchItems { get; set; }
    
    }
}
