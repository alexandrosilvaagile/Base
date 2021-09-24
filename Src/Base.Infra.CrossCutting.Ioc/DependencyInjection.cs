using Base.Domain.Interfaces.Repositories;
using Base.Infra.Data.Contexts;
using Base.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Base.Infra.CrossCutting.Ioc
{
    public static class DependencyInjection
    {
        public static void AddServices(this IServiceCollection services, Assembly apiAssembly)
        {
            services.AddScoped<IFakeRopository, FakeRopository>();

            services.AddDbContext<Context>();
        }
    }
}
