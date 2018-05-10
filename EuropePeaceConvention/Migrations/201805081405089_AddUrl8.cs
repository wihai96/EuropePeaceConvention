namespace EuropePeaceConvention.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrl8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CommentModels", "AccountId", c => c.Int(nullable: false));
            DropColumn("dbo.CommentModels", "CommentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CommentModels", "CommentId", c => c.Int(nullable: false));
            DropColumn("dbo.CommentModels", "AccountId");
        }
    }
}
