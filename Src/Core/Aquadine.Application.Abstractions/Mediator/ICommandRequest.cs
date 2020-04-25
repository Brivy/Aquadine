using MediatR;

namespace Aquadine.Application.Abstractions.Mediator
{
    public interface ICommandRequest<TResponse> : IRequest<TResponse>
    {
    }
}
