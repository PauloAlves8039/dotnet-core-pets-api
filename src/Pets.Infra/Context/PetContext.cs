using Microsoft.EntityFrameworkCore;
using Pets.Domain.Entities;
using Pets.Infra.Mapping;

namespace Pets.Infra.Context
{
    public class PetContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }

        public PetContext(DbContextOptions<PetContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pet>(new PetMap().Configure);
        }
    }
}
