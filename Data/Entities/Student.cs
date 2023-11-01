namespace SchoolAPI.Data.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }

    }
}
