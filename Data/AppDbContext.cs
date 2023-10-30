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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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
                LastName = "Krsikapa"
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 2,
                FirstName = "John",
                LastName = "Doe"
            });
        }
    }
}
