namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingRegisterInformation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserAccounts", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.UserAccounts", new[] { "User_Id" });
            DropColumn("dbo.UserAccounts", "AplicationUserId");
            DropColumn("dbo.UserAccounts", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserAccounts", "User_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.UserAccounts", "AplicationUserId", c => c.String());
            CreateIndex("dbo.UserAccounts", "User_Id");
            AddForeignKey("dbo.UserAccounts", "User_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
