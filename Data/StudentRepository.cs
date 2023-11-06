using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SchoolAPI.Data.Entities;
using SchoolAPI.Models;

namespace SchoolAPI.Data
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _db;

        public StudentRepository(AppDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Student> AllStudents => _db.Students.Include(s => s.Department);

        public Student? AddStudent(Student newStudent)
        {
            _db.Students.Add(newStudent);
            _db.SaveChanges();
            return newStudent;
        }

        public bool DeleteStudent(int deletedStudentId)
        {
            Student? studentToDelete = GetStudentById(deletedStudentId);
            if(studentToDelete != null)
            {
                _db.Remove(studentToDelete);
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Student? GetStudentById(int? id)
        {
            Student? result;

            result = _db.Students.Include(s => s.Department).FirstOrDefault(s => s.Id == id);
            return result;
        }

        public Student? UpdateStudent(Student updatedStudent)
        {
            Student? studentToUpdate = GetStudentById(updatedStudent.Id);
            if(studentToUpdate != null)
            {
                studentToUpdate.FirstName = updatedStudent.FirstName;
                studentToUpdate.LastName = updatedStudent.LastName;
                studentToUpdate.DepartmentId = updatedStudent.DepartmentId;
                _db.SaveChanges();
            }
            return studentToUpdate;
        }
    }
}
