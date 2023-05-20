using Domain.Bases.Entities;

namespace Domain.Bases.Interfaces
{
    public interface IBaseReadAsync<TEntity, TId>
        : IBaseFindAllAsync<TEntity, TId>
        , IBaseFindByIdAsync<TEntity, TId>
        where TEntity : BaseEntity<TId>
    {
    }
}
