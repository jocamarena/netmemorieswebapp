using WebApplication1.Models;

namespace WebApplication1.Repository.IRepository
{
    public interface IMemoryRepository : IRepository<Memory>
    {
        int Save();
        void Update(Memory memory);
    }
}
