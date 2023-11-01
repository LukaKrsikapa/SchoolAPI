using SchoolAPI.Data.Entities;

namespace SchoolAPI.Data
{
    public interface IDepartmentRepository
    {
        public IEnumerable<Department> AllDepartments { get; }
        public Department GetDepartmentById(int id);
    }
}
