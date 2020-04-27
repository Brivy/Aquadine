using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Aquadine.Application.Core.Interfaces.Mediator
{
    public interface ICommandSender
    {
        Task SendRequestAsync(IRequest command, CancellationToken cancellationToken);

        Task<TResponse> SendRequestAsync<TResponse>(IRequest<TResponse> command, CancellationToken cancellationToken);
    }
}
