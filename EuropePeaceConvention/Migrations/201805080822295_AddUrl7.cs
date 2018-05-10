namespace EuropePeaceConvention.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrl7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CommentModels", "CommentId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CommentModels", "CommentId");
        }
    }
}
