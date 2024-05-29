namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_headingstatusadd1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Headings", "HeadingStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Headings", "HeadingStatus", c => c.Int(nullable: false));
        }
    }
}
