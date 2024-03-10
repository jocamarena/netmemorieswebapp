using WebApplication1.Models;
using WebApplication1.Repository.IRepository;

namespace WebApplication1.Repository
{
    public class MemoryRepository : IMemoryRepository, IRepository<Memory>
    {
        public ICollection<Memory> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
