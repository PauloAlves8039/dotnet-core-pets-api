using Microsoft.Extensions.DependencyInjection;
using Pets.Domain.Interfaces.Services;
using Pets.Service.Services;

namespace Pets.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceColletion) 
        {
            serviceColletion.AddTransient<IPetService, PetService>();
        }
    }
}
