namespace EuropePeaceConvention.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrl9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CommentModels", "ArticleId", c => c.Int(nullable: false));
            DropColumn("dbo.CommentModels", "AccountId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CommentModels", "AccountId", c => c.Int(nullable: false));
            DropColumn("dbo.CommentModels", "ArticleId");
        }
    }
}
