using Microsoft.EntityFrameworkCore;
using SchoolAPI.Data.Entities;

namespace SchoolAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Final> Finals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Final>().HasData(new Final { Id = 1, Name = "Primer polaganja 1", CourseId = 1, Date = DateTime.Today, Mark = 10, StudentId = 1 });
            modelBuilder.Entity<Final>().HasData(new Final { Id = 2, Name = "Primer polaganja 2", CourseId = 1, Date = DateTime.Today, Mark = 10, StudentId = 2 });
            modelBuilder.Entity<Final>().HasData(new Final { Id = 3, Name = "Primer polaganja 3", CourseId = 2, Date = DateTime.Today, Mark = 10, StudentId = 1 });

            modelBuilder.Entity<Department>().HasData(new Department
            {
                Id = 1,
                Name = "Microsoft Web Development"
            });
            modelBuilder.Entity<Department>().HasData(new Department
            {
                Id = 2,
                Name = "Microsoft Desktop Development"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 1,
                Name = "Microsoft Web Services",
                NumberOfClasses = 32
            });
            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 2,
                Name = "ASP.NET Core MVC",
                NumberOfClasses = 44
            });
            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 3,
                Name = "Introduction To Web Development",
                NumberOfClasses = 32
            });

            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 1,
                FirstName = "Luka",
                LastName = "Krsikapa",
                DepartmentId = 2
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 2,
                FirstName = "John",
                LastName = "Doe",
                DepartmentId = 1
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 3,
                FirstName = "Radovan",
                LastName = "Andjelkovic",
                DepartmentId = 2
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 4,
                FirstName = "Kristina",
                LastName = "Jakovljevic",
                DepartmentId = 1
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 5,
                FirstName = "Tijana",
                LastName = "Gladic",
                DepartmentId = 1
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 6,
                FirstName = "Andrija",
                LastName = "Marjanovic",
                DepartmentId = 1
            });
        }
    }
}
