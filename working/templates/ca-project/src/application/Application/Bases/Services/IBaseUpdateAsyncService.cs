using Application.Bases.Dtos;

namespace Application.Bases.Services
{
    public interface IBaseUpdateAsyncService<TRequest, TResponse>
    where TRequest : BaseRequest
    where TResponse : BaseResponse
    {
        Task<TResponse> UpdateAsync(TRequest request, CancellationToken cancellationToken);
    }
}
