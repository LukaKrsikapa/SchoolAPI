using System.ComponentModel.DataAnnotations;

namespace SchoolAPI.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(20)]
        public string? LastName { get; set; }
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
    }
}
