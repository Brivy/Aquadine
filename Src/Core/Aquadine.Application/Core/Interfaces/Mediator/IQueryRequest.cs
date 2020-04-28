using MediatR;

namespace Aquadine.Application.Core.Interfaces.Mediator
{
    public interface IQueryRequest<TResponse> : IRequest<TResponse>
    {
    }
}
