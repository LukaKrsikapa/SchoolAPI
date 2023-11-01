using AutoMapper;
using SchoolAPI.Data.Entities;
using SchoolAPI.Models;

namespace SchoolAPI.Data
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            this.CreateMap<Student, StudentModel>();
            this.CreateMap<StudentModel, Student>();
        }
    }
}
