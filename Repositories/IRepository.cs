namespace FinanceTrackingAPI.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(Guid id);
        Task<T> DeleteAsync(Guid id);
        Task<T> UpdateAsync(T entity);
    }
}
