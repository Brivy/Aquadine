using Aquadine.Application.Core.Interfaces.Mediator;
using Aquadine.Application.Core.Services.Mediator;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Reflection;

namespace Aquadine.Application
{
    public static class Startup
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration, List<Assembly> assemblies)
        {
            services.AddMediatorService(assemblies);
        }

        private static void AddMediatorService(this IServiceCollection services, List<Assembly> assemblies)
        {
            services.AddMediatR(assemblies.ToArray());

            services.AddScoped(typeof(ICommandSender), typeof(CommandService));
            services.AddScoped(typeof(IEventPublisher), typeof(EventService));
            services.AddScoped(typeof(IQuerySender), typeof(QueryService));
        }
    }
}
