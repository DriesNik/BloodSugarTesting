namespace BllodSugarTester.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingBloodSugarTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BloodSugar",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Time = c.String(nullable: false),
                    Date = c.String(nullable: false),
                    BloodSugar = c.Int(nullable: false),
                    AboveRange = c.Boolean(),
                    InRange = c.Boolean(),
                    BelowRange = c.Boolean(),
                    UserId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BloodSugar", "UserName", "dbo.AspNetUsers");
            DropIndex("dbo.BloodSugar", "UserName");

        }
    }
}
