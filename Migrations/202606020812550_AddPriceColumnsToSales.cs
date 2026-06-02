namespace BranchSalesAutomation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddPriceColumnsToSales : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sales", "unit_price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Sales", "total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }

        public override void Down()
        {
            DropColumn("dbo.Sales", "total");
            DropColumn("dbo.Sales", "unit_price");
        }
    }
} 