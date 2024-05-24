using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Application;

public static class ApplicationServiceRegistration
{
    //extance yazıyoruz
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // MediatR git bütün assembly tara  tüm command queryleri bul. Onların hanlerlerini bul ve eşle,
        // ben sana command veya query send yaparsam getir.
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
           
        });
        return services;
    }
}
