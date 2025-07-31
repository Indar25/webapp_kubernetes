using Microsoft.Extensions.DependencyInjection;
using practice.Application.Queries;

namespace practice.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {

        services.AddMediatR(cfg =>
                cfg.RegisterServicesFromAssembly(typeof(GetAllEmployeeQuery).Assembly));

        return services;
    }
}
