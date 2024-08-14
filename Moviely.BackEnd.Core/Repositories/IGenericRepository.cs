using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviely.BackEnd.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<T> GetByIdAsync(int id);

        public List<T> GetAll();

        public Task AddAsync(T Entity);

        public void Update(T Entity);

        public void Delete(T Entity);

       // Task<List<T>> FindByForeignIdEnties(int id); Bu fonksiyon ICommentRepoda olmalı.


    }
}
