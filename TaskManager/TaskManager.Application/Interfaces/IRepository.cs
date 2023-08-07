namespace TaskManager.Application.Interfaces
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Guid id);
        Task Add(T entity);
        Task Update(T entity);
        Task<T> Remove(Guid id);
        Task SaveChanges();
    }
}
