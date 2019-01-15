namespace StudentWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Students", "StudentId", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Students", "Address", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Address", c => c.String());
            AlterColumn("dbo.Students", "Name", c => c.String());
            AlterColumn("dbo.Students", "StudentId", c => c.String());
            AlterColumn("dbo.Courses", "Name", c => c.String());
        }
    }
}
