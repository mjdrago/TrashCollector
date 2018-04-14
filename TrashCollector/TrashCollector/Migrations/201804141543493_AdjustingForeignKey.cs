namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdjustingForeignKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserAccounts", "AplicationUserId", c => c.String());
            DropColumn("dbo.UserAccounts", "ApllicationUserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserAccounts", "ApllicationUserId", c => c.String());
            DropColumn("dbo.UserAccounts", "AplicationUserId");
        }
    }
}
