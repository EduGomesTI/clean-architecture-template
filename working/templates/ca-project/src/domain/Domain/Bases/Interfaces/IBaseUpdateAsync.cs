using Domain.Bases.Entities;

namespace Domain.Bases.Interfaces
{
    public interface IBaseUpdateAsync<TEntity, TId> where TEntity : BaseEntity<TId>
    {
        Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken);
    }
}
