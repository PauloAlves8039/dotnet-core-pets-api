using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pets.Domain.Interfaces;
using Pets.Infra.Context;
using Pets.Infra.Repositories;

namespace Pets.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection) 
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            serviceCollection.AddDbContext<PetContext>(
                options => options.UseMySql("Server=127.0.0.1;Port=3306;Database=petDB;Uid=root;Pwd=Masterkey123"));
        }
    }
}
