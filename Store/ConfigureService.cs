using Application.Contracts;
using Infrastructure.Persistence;
using MediatR;

namespace Store
{
    public static class ConfigureService
    {
        public static IServiceCollection AddWebServiceCollecton(this IServiceCollection builder)
        {
            builder.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.AddTransient<IMediator, Mediator>();
            return builder;
        }
    }
}
