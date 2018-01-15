namespace BookLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FifthCommitFix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "CreatedAt", c => c.String());
            AddColumn("dbo.Books", "UpdatedAt", c => c.String());
            AddColumn("dbo.Books", "UserBookRelation_Id", c => c.Int());
            AddColumn("dbo.UserBookRelations", "CreatedAt", c => c.String());
            AddColumn("dbo.UserBookRelations", "UpdatedAt", c => c.String());
            CreateIndex("dbo.Books", "UserBookRelation_Id");
            AddForeignKey("dbo.Books", "UserBookRelation_Id", "dbo.UserBookRelations", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "UserBookRelation_Id", "dbo.UserBookRelations");
            DropIndex("dbo.Books", new[] { "UserBookRelation_Id" });
            DropColumn("dbo.UserBookRelations", "UpdatedAt");
            DropColumn("dbo.UserBookRelations", "CreatedAt");
            DropColumn("dbo.UserBookRelations", "LastName");
            DropColumn("dbo.UserBookRelations", "FirstName");
            DropColumn("dbo.Books", "UserBookRelation_Id");
            DropColumn("dbo.Books", "UpdatedAt");
            DropColumn("dbo.Books", "CreatedAt");
        }
    }
}
