namespace Competition.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class minscore : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ScoreDetails", "ScoreId", "dbo.Scores");
            AddColumn("dbo.EventCriterias", "MinScore", c => c.Int(nullable: false));
            AddForeignKey("dbo.ScoreDetails", "ScoreId", "dbo.Scores", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ScoreDetails", "ScoreId", "dbo.Scores");
            DropColumn("dbo.EventCriterias", "MinScore");
            AddForeignKey("dbo.ScoreDetails", "ScoreId", "dbo.Scores", "Id");
        }
    }
}
