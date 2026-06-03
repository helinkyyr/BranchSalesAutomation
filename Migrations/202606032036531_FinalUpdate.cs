namespace BranchSalesAutomation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinalUpdate : DbMigration
    {
        public override void Up()
        {
             
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        country_id = c.Int(nullable: false, identity: true),
                        country_name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.country_id);
            
        }
    }
}
