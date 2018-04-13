namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdjustingTableParameters : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserAccounts", "FirstName", c => c.String(nullable: false, maxLength: 25, unicode: false));
            AlterColumn("dbo.UserAccounts", "MiddleInitial", c => c.String(maxLength: 1, unicode: false));
            AlterColumn("dbo.UserAccounts", "LastName", c => c.String(nullable: false, maxLength: 25, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserAccounts", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.UserAccounts", "MiddleInitial", c => c.String());
            AlterColumn("dbo.UserAccounts", "FirstName", c => c.String(nullable: false, maxLength: 8000, unicode: false));
        }
    }
}
