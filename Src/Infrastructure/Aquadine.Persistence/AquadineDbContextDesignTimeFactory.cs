using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Aquadine.Persistence
{
    public class AquadineDbContextDesignTimeFactory : IDesignTimeDbContextFactory<AquadineDbContext>
    {
        public AquadineDbContext CreateDbContext(string[] args)
        {
            var configPath = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "Presentation", "Aquadine.Presentation");
            
            // TODO: Doesn't work??
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var configuration = new ConfigurationBuilder()
                .SetBasePath(configPath)
                .AddJsonFile("appsettings.json")
                //.AddJsonFile($"appsettings.{environment}.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder()
                .UseSqlServer(configuration.GetConnectionString("AquadineDbConnection"));

            return new AquadineDbContext(optionsBuilder.Options);
        }
    }
}
