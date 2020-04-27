using MediatR;

namespace Aquadine.Application.Core.Interfaces.Mediator
{
    public interface ICommandRequest<TResponse> : IRequest<TResponse>
    {
    }
}
