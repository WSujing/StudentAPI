using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace StudentWebAPI.Models
{
    public class ApplicationDbContext: DbContext
    {        
        public ApplicationDbContext() : base("DefaultConnection") { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}