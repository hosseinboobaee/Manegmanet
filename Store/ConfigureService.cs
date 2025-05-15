using Application.Contracts;
using Application.Utility.TokenService;
using Infrastructure.Persistence;
using MediatR;

namespace Store
{
    public static class ConfigureService
    {
        public static IServiceCollection AddWebServiceCollecton(this IServiceCollection builder)
        {

            builder.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.AddScoped<ITokenService, TokenServises>();
            builder.AddTransient<IMediator, Mediator>();

            return builder;
        }
    }
}
