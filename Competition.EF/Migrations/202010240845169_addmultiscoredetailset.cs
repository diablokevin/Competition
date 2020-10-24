namespace Competition.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmultiscoredetailset : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "MultiScoreDetailSet", c => c.Boolean(nullable: false));
            AddColumn("dbo.EventCriterias", "SetId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EventCriterias", "SetId");
            DropColumn("dbo.Events", "MultiScoreDetailSet");
        }
    }
}
