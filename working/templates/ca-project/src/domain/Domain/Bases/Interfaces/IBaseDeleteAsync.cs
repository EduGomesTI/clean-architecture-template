using Domain.Bases.Entities;

namespace Domain.Bases.Interfaces
{
    public interface IBaseDeleteAsync<TEntity, TId> where TEntity : BaseEntity<TId>
    {
        Task DeleteAsync(TEntity entity, CancellationToken cancellationToken);
    }
}
