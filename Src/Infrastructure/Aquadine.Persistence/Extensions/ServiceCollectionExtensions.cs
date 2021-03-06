﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Aquadine.Persistence.Extensions
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Automatically dependency inject repositories
        /// </summary>
        /// <param name="services"></param>
        /// <param name="repoNameSpace"></param>
        /// <param name="interfaceNameSpace"></param>
        public static void AddRepositories(this IServiceCollection services, string repoNameSpace, string interfaceNameSpace)
        {
            var repositories = Assembly.GetExecutingAssembly().GetTypes()
                .Where(x => string.Equals(x.Namespace, repoNameSpace, StringComparison.Ordinal));

            foreach (var repo in repositories)
            {
                var filter = Attribute.GetCustomAttribute(repo, typeof(CompilerGeneratedAttribute));

                // Skip dependency injection for compiler generated types
                if (filter != null)
                {
                    continue;
                }

                // Get the repository interface and throw an exception if more than one repository interface is found
                var repoInterface = repo.GetInterfaces()
                    .Where(x => string.Equals(x.Namespace, interfaceNameSpace, StringComparison.Ordinal))
                    .Single();

                services.AddScoped(repoInterface, repo);
            }
        }
    }
}
