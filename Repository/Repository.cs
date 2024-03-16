using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApplication1.Data;
using WebApplication1.Models;
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
            dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _context.Add(entity);
        }

        public ICollection<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);
            T t = query.FirstOrDefault();
            return t;
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
