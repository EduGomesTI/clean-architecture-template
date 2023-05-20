using Domain.Bases.Entities;
using Domain.Bases.Interfaces;

namespace Domain.Bases.Repositories
{
    public interface IBaseReadRepository<TEntity, TId> : IBaseReadAsync<TEntity, TId> where TEntity : BaseEntity<TId>
    {
    }
}
