namespace Competition.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetIdToSetName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EventCriterias", "SetName", c => c.String());
            DropColumn("dbo.EventCriterias", "SetId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EventCriterias", "SetId", c => c.Int(nullable: false));
            DropColumn("dbo.EventCriterias", "SetName");
        }
    }
}
