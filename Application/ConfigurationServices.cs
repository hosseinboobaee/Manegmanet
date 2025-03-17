using Core.Utilities.Mapping;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class ConfigurationServices
    {
        public static void ApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            #region AutoMapper
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            #endregion

        }
    }
}
