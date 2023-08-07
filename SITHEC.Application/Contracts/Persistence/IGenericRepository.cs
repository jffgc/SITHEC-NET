namespace SITHEC.Application.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Add(T entity);
        Task Update(T entity);
        Task<T> GetById(Guid id);
        Task<IReadOnlyList<T>> GetAll();

    }
}
