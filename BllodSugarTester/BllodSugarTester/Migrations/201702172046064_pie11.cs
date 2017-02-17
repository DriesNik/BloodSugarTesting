namespace BllodSugarTester.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pie11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.caltoids",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        calenID = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.caltoids");
        }
    }
}
