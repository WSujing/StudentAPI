namespace StudentWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedDb : DbMigration
    {
        public override void Up()
        {             
            Sql("INSERT INTO Courses(Name) VALUES ('Bussiness Administration')");
            Sql("INSERT INTO Courses(Name) VALUES ('Finance')");
            Sql("INSERT INTO Courses(Name) VALUES ('Real Estate Management')");
            Sql("INSERT INTO Courses(Name) VALUES ('Accounting and Auditing')");

        }
        
        public override void Down()
        {
        }
    }
}
