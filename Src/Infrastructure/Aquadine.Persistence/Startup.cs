using Aquadine.Persistence.Extensions;
using Aquadine.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Aquadine.Persistence
{
    public static class Startup
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            const string repoNameSpace = "Aquadine.Persistence.Repositories";
            const string interfaceNameSpace = "Aquadine.Persistence.Repositories.Interfaces";

            services.AddRepositories(repoNameSpace, interfaceNameSpace);

            services.AddDbContext<IAquadineContext, AquadineContext>((options) => 
                options.UseSqlServer(configuration.GetConnectionString("AquadineDbConnection")));
        }
    }
}
