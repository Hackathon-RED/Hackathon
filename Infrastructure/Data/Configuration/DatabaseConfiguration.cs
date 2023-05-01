using Infrastructure.Data.Context;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HappyPet.Infrastructure.Data.Configuration
{
    public static class DatabaseConfiguration
    {
        public static void ConfiguraBanco(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("HappyPet.Infrastructure"));
            });

            // Adicionar aqui outras configurações dos repositórios, se houver
            services.AddScoped<IVeterinarioRepository>(provider => (IVeterinarioRepository)provider.GetService<DataContext>());
        }
    }
}
