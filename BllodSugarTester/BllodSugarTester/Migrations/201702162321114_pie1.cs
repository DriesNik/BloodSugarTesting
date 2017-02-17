namespace BllodSugarTester.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pie1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BloodSugars", "AboveRange", c => c.Boolean(nullable: false));
            AddColumn("dbo.BloodSugars", "BelowRange", c => c.Boolean(nullable: false));
            AddColumn("dbo.BloodSugars", "InRange", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BloodSugars", "InRange");
            DropColumn("dbo.BloodSugars", "BelowRange");
            DropColumn("dbo.BloodSugars", "AboveRange");
        }
    }
}
