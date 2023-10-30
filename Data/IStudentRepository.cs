using SchoolAPI.Data.Entities;

namespace SchoolAPI.Data
{
    public interface IStudentRepository
    {
        public IEnumerable<Student> AllStudents { get; }
        Student GetStudentById(int id);
    }
}
