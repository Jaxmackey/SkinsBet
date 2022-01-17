using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using SkinsBetApp.Repositories;

namespace Infrastructure
{
    public static class InfrastructureModule
    {
        public static void AddHttpFactories(this IServiceCollection services)
        {
            services.AddHttpClient<ISteamRepository, SteamRepository>();
        }
    }
}