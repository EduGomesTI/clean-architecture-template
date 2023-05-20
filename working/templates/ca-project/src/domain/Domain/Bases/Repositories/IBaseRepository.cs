using Domain.Bases.Entities;

namespace Domain.Bases.Repositories
{
    public interface IBaseRepository<TEntity, TId> where TEntity : BaseEntity<TId>
    {
    }
}
