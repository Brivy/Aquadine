using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Aquadine.Application.Core.Interfaces.Mediator
{
    public interface IQuerySender
    {
        Task<TResponse> SendQueryAsync<TResponse>(IRequest<TResponse> query, CancellationToken cancellationToken);
    }
}
