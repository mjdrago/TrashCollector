namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinishingRegisterFunction : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserAccounts", "ApllicationUserId", c => c.String());
            AddColumn("dbo.UserAccounts", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.UserAccounts", "User_Id");
            AddForeignKey("dbo.UserAccounts", "User_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserAccounts", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.UserAccounts", new[] { "User_Id" });
            DropColumn("dbo.UserAccounts", "User_Id");
            DropColumn("dbo.UserAccounts", "ApllicationUserId");
        }
    }
}
