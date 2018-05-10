namespace EuropePeaceConvention.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrl5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArticlesModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        User = c.String(),
                        PostDate = c.DateTime(nullable: false),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ArticlesModels");
        }
    }
}
