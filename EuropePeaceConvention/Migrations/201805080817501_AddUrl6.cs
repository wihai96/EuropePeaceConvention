namespace EuropePeaceConvention.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrl6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CommentModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User = c.String(),
                        PostDate = c.DateTime(nullable: false),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CommentModels");
        }
    }
}
