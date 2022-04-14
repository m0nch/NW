using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Microsoft.Extensions.DependencyInjection;

namespace Services
{
    public static class ServiceInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection service)
        {
            service.AddScoped<ICustomerService, CustomerService>();
            service.AddScoped<IEmployeeService, EmployeeService>();
            service.AddScoped<IProductService, ProductService>();
            return service;
        }
    }
}
