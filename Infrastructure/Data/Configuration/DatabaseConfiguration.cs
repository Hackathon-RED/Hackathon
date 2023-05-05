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
            services.AddScoped<IUsuarioRepository>(provider => (IUsuarioRepository)provider.GetService<DataContext>());
            services.AddScoped<IVeterinarioRepository>(provider => (IVeterinarioRepository)provider.GetService<DataContext>());
            services.AddScoped<IMidiaRepository>(provider => (IMidiaRepository)provider.GetService<DataContext>());
            services.AddScoped<IChatRepository>(provider => (IChatRepository)provider.GetService<DataContext>());
            services.AddScoped<IAnimalRepository>(provider => (IAnimalRepository)provider.GetService<DataContext>());
            services.AddScoped<IHistoricoRepository>(provider => (IHistoricoRepository)provider.GetService<DataContext>());
            services.AddScoped<IAdaptacaoRepository>(provider => (IAdaptacaoRepository)provider.GetService<DataContext>());
        }
    }
}
