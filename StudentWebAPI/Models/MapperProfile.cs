using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using StudentWebAPI.Dtos;

namespace StudentWebAPI.Models
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<Student, StudentDto>();
            CreateMap<StudentDto, Student>();
        }
    }
}