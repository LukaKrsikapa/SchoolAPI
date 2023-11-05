using SchoolAPI.Data.Entities;
using SchoolAPI.Models;

namespace SchoolAPI.Data
{
    public interface IStudentRepository
    {
        public IEnumerable<Student> AllStudents { get; }
        Student GetStudentById(int? id);
        Student AddStudent(Student newStudent);
        Student UpdateStudent(Student newStudent);
    }
}
