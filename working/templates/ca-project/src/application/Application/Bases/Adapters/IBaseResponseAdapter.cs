using Application.Bases.Dtos;
using Domain.Bases.Entities;

namespace Application.Bases.Adapters
{
    internal interface IBaseResponseAdapter<TEntity, TId, TResponse>
    where TEntity : BaseEntity<TId>
    where TResponse : BaseResponse
    {
        TResponse Adapt(TEntity entity);
    }
}
