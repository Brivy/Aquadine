using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Aquadine.Application.Abstractions.Mediator
{
    public interface IQuerySender
    {
        Task<TResponse> SendQueryAsync<TResponse>(IRequest<TResponse> query, CancellationToken cancellationToken); 
    }
}
