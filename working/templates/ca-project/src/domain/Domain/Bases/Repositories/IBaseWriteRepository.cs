using Domain.Bases.Entities;
using Domain.Bases.Interfaces;

namespace Domain.Bases.Repositories
{
    public interface IBaseWriteRepository<TEntity, TId> : IBaseWriteAsync<TEntity, TId> where TEntity : BaseEntity<TId>
    {
    }
}
