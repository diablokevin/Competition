namespace Competition.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class scoreNote : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Scores", "Note", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Scores", "Note");
        }
    }
}
