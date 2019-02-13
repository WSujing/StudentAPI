using StudentWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using StudentWebAPI.Dtos;

namespace StudentWebAPI.Controllers
{
    public class CourseController : ApiController
    {
        private ApplicationDbContext _context;
        public CourseController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetCourses()
        {
            var courses = _context.Courses.ToList();
            var coursesDto = Mapper.Map<IEnumerable<Course>, IEnumerable<CourseDto>>(courses);
            return Ok(coursesDto);
        }
    }
}
