namespace BookLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RegistrationChanges : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Books",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            BookName = c.String(nullable: false),
            //            RentPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            ApplicationUserId = c.String(maxLength: 128),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId)
            //    .Index(t => t.ApplicationUserId);
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.Books", "ApplicationUserId", "dbo.AspNetUsers");
            //DropIndex("dbo.Books", new[] { "ApplicationUserId" });
            //DropTable("dbo.Books");
        }
    }
}
