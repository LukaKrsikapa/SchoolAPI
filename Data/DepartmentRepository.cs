using SchoolAPI.Data.Entities;

namespace SchoolAPI.Data
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _db;

        public DepartmentRepository(AppDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Department> AllDepartments => _db.Departments;

        public Department GetDepartmentById(int id)
        {
            return _db.Departments.FirstOrDefault(d => d.Id == id);
        }
    }
}
