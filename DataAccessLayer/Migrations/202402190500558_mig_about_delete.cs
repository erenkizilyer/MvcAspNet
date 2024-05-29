namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_about_delete : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Abouts", "assa");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Abouts", "assa", c => c.Int(nullable: false));
        }
    }
}
