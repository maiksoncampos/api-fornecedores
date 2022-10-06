using Fornecedores.Business.Interfaces;
using Fornecedores.Business.Notificacoes;
using Fornecedores.Business.Services;
using Fornecedores.Data.Context;
using Fornecedores.Data.Repository;

namespace Fornecedores.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<FornecedoresDbContext>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IFornecedorService, FornecedorService>();

            return services;
        }
    }
}
