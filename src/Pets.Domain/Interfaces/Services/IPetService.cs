using Pets.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pets.Domain.Interfaces.Services
{
    public interface IPetService
    {
        Task<IEnumerable<Pet>> GetAllPets();
        Task<Pet> GetPetById(int id);
        Task<Pet> PostPet(Pet pet);
        Task<Pet> PutPet(Pet pet);
        Task<bool> DeletePet(int id);
    }
}
