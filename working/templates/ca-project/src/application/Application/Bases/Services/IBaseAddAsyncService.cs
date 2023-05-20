using Application.Bases.Dtos;

namespace Application.Bases.Services
{
    public interface IBaseAddAsyncService<TRequest, TResponse>
    where TRequest : BaseRequest
    where TResponse : BaseResponse
    {
        Task<TResponse> AddAsync(TRequest request, CancellationToken cancellationToken);
    }
}
