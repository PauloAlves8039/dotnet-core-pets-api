using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Pets.Infra.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<PetContext>
    {
        public PetContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=127.0.0.1;Port=3306;Database=petDB;Uid=root;Pwd=Masterkey123";
            var optionBuilder = new DbContextOptionsBuilder<PetContext>();
            optionBuilder.UseMySql(connectionString);
            return new PetContext(optionBuilder.Options);
        }
    }
}
