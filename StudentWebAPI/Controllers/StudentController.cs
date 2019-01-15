using StudentWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;

namespace StudentWebAPI.Controllers
{
    public class StudentController : ApiController
    {
        private ApplicationDbContext _context;
        public StudentController()
        {
            _context = new ApplicationDbContext();
        }
        //Get /api/Student
        public IHttpActionResult GetStudents()
        {
            var students = _context.Students.Include(c => c.Course).ToList();

            return Ok(students);
        }

        //Get /api/Student/1
        public IHttpActionResult GetStudent(int id)
        {
            var student = _context.Students.Include(c => c.Course).SingleOrDefault(c => c.Id == id);

            if (student == null)
                return NotFound();

            return Ok(student);
        }

        //Post /api/Student
        [HttpPost]
        public IHttpActionResult PostStudent(Student student)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _context.Students.Add(student);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + student.Id), student);
            //return Ok(student);

        }

        //Put /api/Student/1
        [HttpPut]
        public IHttpActionResult PutStudent(int id, Student student)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var studentInDb = _context.Students.Include(c => c.Course).SingleOrDefault(c => c.Id == id);

            if (studentInDb == null)
                return NotFound();

            studentInDb.StudentId = student.StudentId;
            studentInDb.Name = student.Name;
            studentInDb.Address = student.Address;
            studentInDb.CourseId = student.CourseId;

            _context.SaveChanges();

            return Ok();
        }

        //Delete /api/Student/1
        [HttpDelete]
        public IHttpActionResult DeleteStudent(int id)
        {
            var student = _context.Students.SingleOrDefault(c => c.Id == id);

            if (student == null)
                return NotFound();

            _context.Students.Remove(student);
            _context.SaveChanges();

            return Ok();
        }
        
    }
}
