using Domain.Bases.Entities;

namespace Domain.Bases.Interfaces
{
    public interface IBaseAddAsync<TEntity, TId> where TEntity : BaseEntity<TId>
    {
        Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken);
    }
}
