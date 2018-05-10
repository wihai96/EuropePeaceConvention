namespace EuropePeaceConvention.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrl3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CountriesModels", "Area", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CountriesModels", "Area", c => c.Int(nullable: false));
        }
    }
}
