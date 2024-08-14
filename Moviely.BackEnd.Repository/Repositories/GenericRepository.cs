using Microsoft.EntityFrameworkCore;
using Moviely.BackEnd.Core.Repositories;
using Moviely.BackEnd.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviely.BackEnd.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task AddAsync(T Entity)
        {
            await _dbSet.AddAsync(Entity);
        }

        public void Delete(T Entity)
        {
            _dbSet.Remove(Entity);
        }

        public Task<List<T>> FindByForeignIdEnties(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            var data = _dbSet.ToList();
            return data;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var data = await _dbSet.FindAsync(id);
            return data;
        }

        public void Update(T Entity)
        {
            _dbSet.Update(Entity);
        }

       
    }
}
