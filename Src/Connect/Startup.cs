using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Reflection;

namespace Aquadine.Connect
{
    public static class Startup
    {
        public static void ConnectAquadineProjects(this IServiceCollection servies, IConfiguration configuration, Assembly callingAssembly)
        {
            var assemblyList = new List<Assembly>
            { 
                callingAssembly,
                typeof(Application.Startup).Assembly,
                typeof(Persistence.Startup).Assembly
            };

            servies.ConnectCore(configuration, assemblyList);
            servies.ConnectInfrastructure(configuration);
        }

        private static void ConnectCore(this IServiceCollection services, IConfiguration configuration, List<Assembly> assemblyList)
        {
            Application.Startup.ConfigureServices(services, configuration, assemblyList);
        }

        private static void ConnectInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            Persistence.Startup.ConfigureServices(services, configuration);
        }
    }
}
