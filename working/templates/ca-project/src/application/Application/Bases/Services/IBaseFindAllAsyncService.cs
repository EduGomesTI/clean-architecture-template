using Application.Bases.Dtos;

namespace Application.Bases.Services
{
    public interface IBaseFindAllAsyncService<TResponse>
    where TResponse : BaseResponse
    {
        Task<TResponse> FindAllAsync(CancellationToken cancellationToken);
    }
}
