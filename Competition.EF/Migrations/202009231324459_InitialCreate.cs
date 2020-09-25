namespace Competition.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chips",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Serial = c.Int(nullable: false),
                        Name = c.String(),
                        EventId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .Index(t => t.EventId);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Pro = c.String(),
                        MenuOrder = c.Int(nullable: false),
                        TimeLimit = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventId = c.Int(nullable: false),
                        CompetitorId = c.Int(),
                        PlanBeginTime = c.DateTime(),
                        PlanEndTime = c.DateTime(),
                        Judge_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Competitors", t => t.CompetitorId)
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .ForeignKey("dbo.Judges", t => t.Judge_Id)
                .Index(t => t.EventId)
                .Index(t => t.CompetitorId)
                .Index(t => t.Judge_Id);
            
            CreateTable(
                "dbo.Competitors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Pro = c.String(),
                        StaffId = c.String(),
                        Race_num = c.String(),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Scores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TimeConsume = c.Time(precision: 7),
                        Mark = c.Double(),
                        JudgeTime = c.DateTime(),
                        ModifyTime = c.DateTime(),
                        ScheduleId = c.Int(nullable: false),
                        JudgeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Judges", t => t.JudgeId)
                .ForeignKey("dbo.Schedules", t => t.ScheduleId, cascadeDelete: true)
                .Index(t => t.ScheduleId)
                .Index(t => t.JudgeId);
            
            CreateTable(
                "dbo.Judges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CompanyId = c.Int(),
                        EventId = c.Int(),
                        StaffId = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId)
                .ForeignKey("dbo.Events", t => t.EventId)
                .Index(t => t.CompanyId)
                .Index(t => t.EventId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Scores", "ScheduleId", "dbo.Schedules");
            DropForeignKey("dbo.Scores", "JudgeId", "dbo.Judges");
            DropForeignKey("dbo.Schedules", "Judge_Id", "dbo.Judges");
            DropForeignKey("dbo.Judges", "EventId", "dbo.Events");
            DropForeignKey("dbo.Judges", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Schedules", "EventId", "dbo.Events");
            DropForeignKey("dbo.Schedules", "CompetitorId", "dbo.Competitors");
            DropForeignKey("dbo.Competitors", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Chips", "EventId", "dbo.Events");
            DropIndex("dbo.Judges", new[] { "EventId" });
            DropIndex("dbo.Judges", new[] { "CompanyId" });
            DropIndex("dbo.Scores", new[] { "JudgeId" });
            DropIndex("dbo.Scores", new[] { "ScheduleId" });
            DropIndex("dbo.Competitors", new[] { "CompanyId" });
            DropIndex("dbo.Schedules", new[] { "Judge_Id" });
            DropIndex("dbo.Schedules", new[] { "CompetitorId" });
            DropIndex("dbo.Schedules", new[] { "EventId" });
            DropIndex("dbo.Chips", new[] { "EventId" });
            DropTable("dbo.Judges");
            DropTable("dbo.Scores");
            DropTable("dbo.Companies");
            DropTable("dbo.Competitors");
            DropTable("dbo.Schedules");
            DropTable("dbo.Events");
            DropTable("dbo.Chips");
        }
    }
}
