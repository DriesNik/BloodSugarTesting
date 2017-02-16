namespace BllodSugarTester.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BloodSugars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.String(),
                        Date = c.String(),
                        BloodSugar = c.String(),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BloodSugars");
        }
    }
}
