namespace BranchSalesAutomation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCountryRelation : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Sales", "stock_id");
            AddForeignKey("dbo.Sales", "stock_id", "dbo.Stock", "stock_id", cascadeDelete: true);
            DropColumn("dbo.Sales", "country_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sales", "country_id", c => c.Int(nullable: false));
            DropForeignKey("dbo.Sales", "stock_id", "dbo.Stock");
            DropIndex("dbo.Sales", new[] { "stock_id" });
        }
    }
}
