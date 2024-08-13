using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviely.BackEnd.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);

        Task<List<T>> GetAll();

        Task AddAsync(T Entity);

        void Update(T Entity);

        void Delete(T Entity);

       // Task<List<T>> FindByForeignIdEnties(int id); Bu fonksiyon ICommentRepoda olmalı.


    }
}
