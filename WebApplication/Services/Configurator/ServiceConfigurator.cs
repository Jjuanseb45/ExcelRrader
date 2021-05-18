using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using WebApplication.Services;

namespace WebApplication.Services.Configurator
{
    public static class ServiceConfigurator
    {
        public static void ConfigurarServicios(this IServiceCollection service)
        {
            service.TryAddTransient<IExcelReaderService, ExcelReaderService>();
        }
    }
}