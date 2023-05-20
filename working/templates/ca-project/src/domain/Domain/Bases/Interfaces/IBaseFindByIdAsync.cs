using Domain.Bases.Entities;

namespace Domain.Bases.Interfaces
{
    public interface IBaseFindByIdAsync<TEntity, TId> where TEntity : BaseEntity<TId>
    {
        Task<TEntity> FindByIdAsync(TId id, CancellationToken cancellationToken);
    }
}
