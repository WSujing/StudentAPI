namespace StudentWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Refactoring : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "AddressId", "dbo.Addresses");
            DropIndex("dbo.Students", new[] { "AddressId" });
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Students", "Address", c => c.String());
            AddColumn("dbo.Students", "CourseId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "CourseId");
            AddForeignKey("dbo.Students", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
            DropColumn("dbo.Students", "AddressId");
            DropTable("dbo.Addresses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.String(),
                        HomeAddress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Students", "AddressId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Students", "CourseId", "dbo.Courses");
            DropIndex("dbo.Students", new[] { "CourseId" });
            DropColumn("dbo.Students", "CourseId");
            DropColumn("dbo.Students", "Address");
            DropTable("dbo.Courses");
            CreateIndex("dbo.Students", "AddressId");
            AddForeignKey("dbo.Students", "AddressId", "dbo.Addresses", "Id", cascadeDelete: true);
        }
    }
}
