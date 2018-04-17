namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateForeignKeyOfAddress : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Addresses", "User_Id", "dbo.UserAccounts");
            DropIndex("dbo.Addresses", new[] { "User_Id" });
            DropColumn("dbo.Addresses", "UserAccountId");
            RenameColumn(table: "dbo.Addresses", name: "User_Id", newName: "UserAccountId");
            AlterColumn("dbo.Addresses", "UserAccountId", c => c.Int(nullable: false));
            AlterColumn("dbo.Addresses", "UserAccountId", c => c.Int(nullable: false));
            CreateIndex("dbo.Addresses", "UserAccountId");
            AddForeignKey("dbo.Addresses", "UserAccountId", "dbo.UserAccounts", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "UserAccountId", "dbo.UserAccounts");
            DropIndex("dbo.Addresses", new[] { "UserAccountId" });
            AlterColumn("dbo.Addresses", "UserAccountId", c => c.Int());
            AlterColumn("dbo.Addresses", "UserAccountId", c => c.String());
            RenameColumn(table: "dbo.Addresses", name: "UserAccountId", newName: "User_Id");
            AddColumn("dbo.Addresses", "UserAccountId", c => c.String());
            CreateIndex("dbo.Addresses", "User_Id");
            AddForeignKey("dbo.Addresses", "User_Id", "dbo.UserAccounts", "Id");
        }
    }
}
