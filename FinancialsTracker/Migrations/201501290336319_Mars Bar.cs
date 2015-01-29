namespace FinancialsTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Purchases : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Purchases", "Name", c => c.String());
            AlterColumn("dbo.Purchases", "Latitude", c => c.Double(nullable: false));
            AlterColumn("dbo.Purchases", "Longitude", c => c.Double(nullable: false));
            AlterColumn("dbo.Purchases", "DateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Purchases", "DateTime", c => c.String());
            AlterColumn("dbo.Purchases", "Longitude", c => c.Single(nullable: false));
            AlterColumn("dbo.Purchases", "Latitude", c => c.Single(nullable: false));
            DropColumn("dbo.Purchases", "Name");
        }
    }
}
