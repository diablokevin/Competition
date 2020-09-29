namespace Competition.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addkanban : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schedules", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Schedules", "Status");
        }
    }
}
