using AutoMapper;
using SchoolAPI.Data.Entities;

namespace SchoolAPI.Data
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            this.CreateMap<Student, StudentProfile>();
        }
    }
}
