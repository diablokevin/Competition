namespace Competition.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAmount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "Amount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "Amount");
        }
    }
}
