using BarberShopV2.Business.Interfaces;
using BarberShopV2.Business.Services;
using System.Runtime.CompilerServices;

namespace BarberShopV2.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {

            // Camada de Dados ainda a ser implementada

            //services.AddScoped<AppDbContext>();
            //services.AddScoped<ICustomerRepository, CustomerRepository>();
            //services.AddScoped<IProfessionalRepository, ProfessionalRepository>();
            //services.AddScoped<IAppointmentRepository, AppointmentRepositoy>();

            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IProfessionalService, ProfessionalService>();
            services.AddScoped<IAppointmentService, AppointmentService>();

            return services;
        }
    }
}
