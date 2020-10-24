namespace Competition.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hastimescore : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "HasTimeScore", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "HasTimeScore");
        }
    }
}
