namespace StudentWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedStudent : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Students(StudentId, Name, Address, CourseId) VALUES ('0978822', 'Mary Wonderland', 'Storgata 1', 1)");
            Sql("INSERT INTO Students(StudentId, Name, Address, CourseId) VALUES ('0978833', 'Micheal Shoemaker', 'Jernbantorget 101', 2)");
            Sql("INSERT INTO Students(StudentId, Name, Address, CourseId) VALUES ('0978844', 'Bill Gates', 'Stortingsgata 20', 3)");
        }
        
        public override void Down()
        {
        }
    }
}
