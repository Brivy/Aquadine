using MediatR;

namespace Aquadine.Application.Abstractions.Mediator
{
    public interface IQueryRequest<TResponse> : IRequest<TResponse>
    {
    }
}
