namespace Competition.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class scoredetail : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventCriterias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        MaxScore = c.Int(nullable: false),
                        Event_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.Event_Id)
                .Index(t => t.Event_Id);
            
            CreateTable(
                "dbo.ScoreDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mark = c.Double(),
                        EventCriteria_Id = c.Int(),
                        Score_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EventCriterias", t => t.EventCriteria_Id)
                .ForeignKey("dbo.Scores", t => t.Score_Id)
                .Index(t => t.EventCriteria_Id)
                .Index(t => t.Score_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ScoreDetails", "Score_Id", "dbo.Scores");
            DropForeignKey("dbo.ScoreDetails", "EventCriteria_Id", "dbo.EventCriterias");
            DropForeignKey("dbo.EventCriterias", "Event_Id", "dbo.Events");
            DropIndex("dbo.ScoreDetails", new[] { "Score_Id" });
            DropIndex("dbo.ScoreDetails", new[] { "EventCriteria_Id" });
            DropIndex("dbo.EventCriterias", new[] { "Event_Id" });
            DropTable("dbo.ScoreDetails");
            DropTable("dbo.EventCriterias");
        }
    }
}
