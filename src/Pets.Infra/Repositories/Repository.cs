using Microsoft.EntityFrameworkCore;
using Pets.Domain.Entities;
using Pets.Domain.Interfaces;
using Pets.Infra.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pets.Infra.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly PetContext _context;
        public DbSet<T> _dataset;

        public Repository(PetContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            try
            {
                return await _dataset.ToListAsync();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public async Task<T> GetById(int id)
        {
            try
            {
                return await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public async Task<T> Insert(T item)
        {
            try
            {
                _dataset.Add(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex) 
            {
                throw ex;
            }

            return item;
        }

        public async Task<T> Update(T item)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(item.Id));

                if (result == null) 
                {
                    return null;
                }

                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex) 
            {
                throw ex;
            }

            return item;
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));

                if (result == null) 
                {
                    return false;
                }

                _dataset.Remove(result);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public async Task<bool> Exist(int id)
        {
            return await _dataset.AnyAsync(p => p.Id.Equals(id));
        }
    }
}
