#if DEBUG
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Aquadine.Persistence
{
    public class AquadineDbContextDesignTimeFactory : IDesignTimeDbContextFactory<AquadineDbContext>
    {
        public AquadineDbContext CreateDbContext(string[] args)
        {
            var jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "../..", "Presentation", "Aquadine.Presentation", "appsettings.Development.json");

            var configuration = new ConfigurationBuilder()
                .AddJsonFile(jsonPath)
                .Build();

            return new AquadineDbContext(new DbContextOptionsBuilder().UseSqlServer(configuration.GetConnectionString("AquadineDbConnection")).Options);
        }
    }
}
#endif