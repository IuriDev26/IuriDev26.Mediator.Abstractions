namespace IuriDev26.Mediator.Abstractions;

public interface IMediator
{
    Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default);
}