using UsuariosApp.Aplication.Interfaces;
using UsuariosApp.Aplication.Services;

namespace UsuariosApp.API.Extensions
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IUsuarioAppService, UsuarioAppService>();

            return services;
        }
    }
}
