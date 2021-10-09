using Pets.Domain.Entities;
using Pets.Domain.Interfaces;
using Pets.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pets.Service.Services
{
    public class PetService : IPetService
    {
        private IRepository<Pet> _repository;

        public PetService(IRepository<Pet> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Pet>> GetAllPets()
        {
            return await _repository.GetAll();
        }

        public async Task<Pet> GetPetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<Pet> PostPet(Pet pet)
        {
            return await _repository.Insert(pet);
        }

        public async Task<Pet> PutPet(Pet pet)
        {
            return await _repository.Update(pet);
        }

        public async Task<bool> DeletePet(int id)
        {
            return await _repository.Delete(id);
        }   
    }
}
