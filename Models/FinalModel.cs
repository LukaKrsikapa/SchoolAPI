using SchoolAPI.Data.Entities;

namespace SchoolAPI.Models
{
    public class FinalModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime Date { get; set; }
        public int Mark { get; set; }
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
        public int StudentId { get; set; }
    }
}
