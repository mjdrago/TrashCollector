namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TryingUserAttachementAgain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserAccounts", "ApplicationUserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.UserAccounts", "ApplicationUserId");
            AddForeignKey("dbo.UserAccounts", "ApplicationUserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserAccounts", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.UserAccounts", new[] { "ApplicationUserId" });
            DropColumn("dbo.UserAccounts", "ApplicationUserId");
        }
    }
}
