namespace _191105581_TruongQuangHy_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameColumnToApplicationUser1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        AttendeeId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.CourseId, t.AttendeeId })
                .ForeignKey("dbo.AspNetUsers", t => t.AttendeeId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .Index(t => t.CourseId)
                .Index(t => t.AttendeeId);
            
            AddColumn("dbo.AspNetUsers", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Attendances", "AttendeeId", "dbo.AspNetUsers");
            DropIndex("dbo.Attendances", new[] { "AttendeeId" });
            DropIndex("dbo.Attendances", new[] { "CourseId" });
            DropColumn("dbo.AspNetUsers", "Name");
            DropTable("dbo.Attendances");
        }
    }
}
