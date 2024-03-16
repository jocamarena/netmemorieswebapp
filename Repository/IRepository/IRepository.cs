using System.Linq.Expressions;
using WebApplication1.Models;

namespace WebApplication1.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        ICollection<T> GetAll();
        T GetFirstOrDefault(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Remove(T entity);
    }
}
