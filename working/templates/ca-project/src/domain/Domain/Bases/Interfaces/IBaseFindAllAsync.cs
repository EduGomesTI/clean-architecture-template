using Domain.Bases.Entities;

namespace Domain.Bases.Interfaces
{
    public interface IBaseFindAllAsync<TEntity, TId> where TEntity : BaseEntity<TId>
    {
        Task<IEnumerable<TEntity>> FindAllAsync(CancellationToken cancellationToken);
    }
}
