namespace Competition.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class scoredetailMarkNotNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ScoreDetails", "Mark", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ScoreDetails", "Mark", c => c.Double());
        }
    }
}
