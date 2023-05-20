using Domain.Bases.Entities;

namespace Domain.Bases.Interfaces
{
    public interface IBaseWriteAsync<TEntity, TId>
        : IBaseAddAsync<TEntity, TId>
        , IBaseDeleteAsync<TEntity, TId>
        , IBaseUpdateAsync<TEntity, TId>
        where TEntity : BaseEntity<TId>
    {
    }
}
