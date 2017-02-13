namespace BllodSugarTester.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RebuildingTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.AspNetUsers",
               c => new
               {
                   Id = c.Int(nullable: false),
                   UserName = c.String(nullable: false, maxLength: 256),
                   FirstName = c.String(),
                   LastName = c.String(),
                   Email = c.String(maxLength: 256),
                   EmailConfirmed = c.Boolean(nullable: false),
                   PasswordHash = c.String(),
                   SecurityStamp = c.String(),
                   DoctorId = c.String(),
                   BSUpperNumber = c.Int(),
                   BSLowerNumber = c.Int(),


               })
            .PrimaryKey(t => t.Id)
            .Index(t => t.UserName, unique: true, name: "UserNameIndex")

            ;
        }
        
        public override void Down()
        {
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropTable("dbo.AspNetUsers");
        }
    }
}
