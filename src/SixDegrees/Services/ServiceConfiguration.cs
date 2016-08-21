using Microsoft.Extensions.DependencyInjection;
using SixDegrees.Core;

namespace SixDegrees.API.Services
{
    public class ServiceConfiguration
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ISixDegreesService>(new SixDegreesService());
        }
    }
}
