using Application.Bases.Dtos;

namespace Application.Bases.Services
{
    public interface IBaseDeleteAsyncService<TRequest, TResponse>
    where TRequest : BaseRequest
    where TResponse : BaseResponse
    {
        Task<TResponse> DeleteAsync(TRequest request, CancellationToken cancellationToken);
    }
}
