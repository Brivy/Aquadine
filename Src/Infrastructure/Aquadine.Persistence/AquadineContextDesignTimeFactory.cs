#if DEBUG
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Aquadine.Persistence
{
    internal class AquadineContextDesignTimeFactory : IDesignTimeDbContextFactory<AquadineContext>
    {
        public AquadineContext CreateDbContext(string[] args)
        {
            var jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "../..", "Presentation", "Aquadine.Presentation", "appsettings.Development.json");

            var configuration = new ConfigurationBuilder()
                .AddJsonFile(jsonPath)
                .Build();

            return new AquadineContext(new DbContextOptionsBuilder().UseSqlServer(configuration.GetConnectionString("AquadineDbConnection")).Options);
        }
    }
}
#endif