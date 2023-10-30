using SchoolAPI.Data.Entities;

namespace SchoolAPI.Data
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _db;

        public StudentRepository(AppDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Student> AllStudents => _db.Students;

        public Student GetStudentById(int id)
        {
            Student result;

            result = _db.Students.FirstOrDefault(s => s.Id == id);
            return result;
        }
    }
}
