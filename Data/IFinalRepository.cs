using SchoolAPI.Data.Entities;

namespace SchoolAPI.Data
{
    public interface IFinalRepository
    {
        public IEnumerable<Final> AllFinals { get; }
        public Final? GetFinalById(int id);
        public IEnumerable<Final>? GetFinalsByStudentId(int id);
        public Final AddFinal(Final newFinal);
    }
}
