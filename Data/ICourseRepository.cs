using SchoolAPI.Data.Entities;

namespace SchoolAPI.Data
{
    public interface ICourseRepository
    {
        public IEnumerable<Course> AllCourses { get; }
    }
}
