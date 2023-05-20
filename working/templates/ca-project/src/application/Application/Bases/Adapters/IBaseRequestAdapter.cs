using Application.Bases.Dtos;
using Domain.Bases.Entities;

namespace Application.Bases.Adapters
{
    internal interface IBaseRequestAdapter<TEntity, TId, TRequest>
        where TEntity : BaseEntity<TId>
        where TRequest : BaseRequest
    {
        TEntity Adapt(TRequest request);
    }
}
