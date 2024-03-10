using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Repository.IRepository;

namespace WebApplication1.Repository
{
    public class Repository<T> :  IRepository<T> where T : class
    {
        private readonly ApplicationDBContext _context;
        internal DbSet<T> dbSet;
        public Repository(ApplicationDBContext context)
        {
            _context = context;
            this.dbSet = _context.Set<T>();
        }
        public ICollection<T> GetAll()
        {
            return dbSet.ToList();
        }
    }
}
