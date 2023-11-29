using AutoMapper;
using SchoolAPI.Data.Entities;
using SchoolAPI.Models;
using System.Runtime.CompilerServices;

namespace SchoolAPI.Data
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            this.CreateMap<CourseModel, Course>();
            this.CreateMap<Course, CourseModel>();
        }
    }
}
