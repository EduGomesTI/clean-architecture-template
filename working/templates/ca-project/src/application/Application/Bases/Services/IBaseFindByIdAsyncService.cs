using Application.Bases.Dtos;

namespace Application.Bases.Services
{
    public interface IBaseFindByIdAsyncService<TId, TResponse>
        where TResponse : BaseResponse
    {
        Task<TResponse> FindByIdAsync(TId id, CancellationToken cancellationToken);
    }
}
