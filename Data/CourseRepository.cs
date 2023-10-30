using SchoolAPI.Data.Entities;

namespace SchoolAPI.Data
{
    public class CourseRepository : ICourseRepository
    {
        private readonly AppDbContext _db;

        public CourseRepository(AppDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Course> AllCourses => _db.Courses;
    }
}
