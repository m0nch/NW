using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class DataInjection
    {
        public static IServiceCollection AddData(this IServiceCollection service)
        {
            service.AddSingleton<NorthwindEntities>();
            return service;
        }

    }
}
