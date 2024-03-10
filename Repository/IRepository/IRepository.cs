namespace WebApplication1.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        ICollection<T> GetAll();
    }
}
