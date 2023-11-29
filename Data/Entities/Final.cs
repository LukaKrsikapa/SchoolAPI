using System.ComponentModel.DataAnnotations;

namespace SchoolAPI.Data.Entities
{
    public class Final
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string Name { get; set; }
        public DateTime Date { get; set; }
        [Required]
        [Range(5, 10)]
        public int Mark { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
