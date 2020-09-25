namespace Competition.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addids : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EventCriterias", "Event_Id", "dbo.Events");
            DropIndex("dbo.EventCriterias", new[] { "Event_Id" });
            DropIndex("dbo.ScoreDetails", new[] { "EventCriteria_Id" });
            DropIndex("dbo.ScoreDetails", new[] { "Score_Id" });
            RenameColumn(table: "dbo.EventCriterias", name: "Event_Id", newName: "EventId");
            RenameColumn(table: "dbo.ScoreDetails", name: "EventCriteria_Id", newName: "EventCriteriaId");
            RenameColumn(table: "dbo.ScoreDetails", name: "Score_Id", newName: "ScoreId");
            AlterColumn("dbo.EventCriterias", "EventId", c => c.Int(nullable: false));
            AlterColumn("dbo.ScoreDetails", "EventCriteriaId", c => c.Int(nullable: false));
            AlterColumn("dbo.ScoreDetails", "ScoreId", c => c.Int(nullable: false));
            CreateIndex("dbo.EventCriterias", "EventId");
            CreateIndex("dbo.ScoreDetails", "EventCriteriaId");
            CreateIndex("dbo.ScoreDetails", "ScoreId");
            AddForeignKey("dbo.EventCriterias", "EventId", "dbo.Events", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EventCriterias", "EventId", "dbo.Events");
            DropIndex("dbo.ScoreDetails", new[] { "ScoreId" });
            DropIndex("dbo.ScoreDetails", new[] { "EventCriteriaId" });
            DropIndex("dbo.EventCriterias", new[] { "EventId" });
            AlterColumn("dbo.ScoreDetails", "ScoreId", c => c.Int());
            AlterColumn("dbo.ScoreDetails", "EventCriteriaId", c => c.Int());
            AlterColumn("dbo.EventCriterias", "EventId", c => c.Int());
            RenameColumn(table: "dbo.ScoreDetails", name: "ScoreId", newName: "Score_Id");
            RenameColumn(table: "dbo.ScoreDetails", name: "EventCriteriaId", newName: "EventCriteria_Id");
            RenameColumn(table: "dbo.EventCriterias", name: "EventId", newName: "Event_Id");
            CreateIndex("dbo.ScoreDetails", "Score_Id");
            CreateIndex("dbo.ScoreDetails", "EventCriteria_Id");
            CreateIndex("dbo.EventCriterias", "Event_Id");
            AddForeignKey("dbo.EventCriterias", "Event_Id", "dbo.Events", "Id");
        }
    }
}
