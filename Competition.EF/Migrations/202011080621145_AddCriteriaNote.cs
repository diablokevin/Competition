namespace Competition.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCriteriaNote : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EventCriterias", "Note", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EventCriterias", "Note");
        }
    }
}
