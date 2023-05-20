using Application.Bases.Dtos;
using Domain.Bases.Entities;

namespace Application.Bases.Adapters
{
    internal abstract class BaseAdapter<TEntity, TId, TRequest, TResponse> : IBaseRequestAdapter<TEntity, TId, TRequest>, IBaseResponseAdapter<TEntity, TId, TResponse>
        where TEntity : BaseEntity<TId>
        where TRequest : BaseRequest
        where TResponse : BaseResponse    
    {

        #region Properties



        #endregion

        #region Constructors



        #endregion

        #region Methods

        public abstract TEntity Adapt(TRequest request);

        public abstract TResponse Adapt(TEntity entity);       

        #endregion

    }
}
