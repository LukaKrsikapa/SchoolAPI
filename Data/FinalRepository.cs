using Microsoft.EntityFrameworkCore;
using SchoolAPI.Data.Entities;

namespace SchoolAPI.Data
{
    public class FinalRepository : IFinalRepository
    {
        private readonly AppDbContext _db;

        public FinalRepository(AppDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Final> AllFinals => _db.Finals;

        public Final AddFinal(Final newFinal)
        {
            newFinal.Date = DateTime.Today;
            _db.Finals.Add(newFinal);
            _db.SaveChanges();

            return newFinal;
        }

        public Final? GetFinalById(int id)
        {
            Final? result = _db.Finals.Include(f => f.Course).FirstOrDefault(f => f.Id == id);
            return result;
        }

        public IEnumerable<Final>? GetFinalsByStudentId(int studentId)
        {
            IEnumerable<Final>? result = _db.Finals.Include(f => f.Course).Where(f => f.StudentId == studentId);
            return result;
        }

        public Final Update(Final final)
        {
            Final updatedFinal = _db.Finals.FirstOrDefault(f => f.Id == final.Id && f.StudentId == final.StudentId);

            if(updatedFinal != null)
            {
                updatedFinal.Mark = final.Mark;
                updatedFinal.Name = final.Name;
                _db.SaveChanges();
            }

            return updatedFinal;
            
        }
    }
}
