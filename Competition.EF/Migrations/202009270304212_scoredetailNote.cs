namespace Competition.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class scoredetailNote : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ScoreDetails", "Note", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ScoreDetails", "Note");
        }
    }
}
