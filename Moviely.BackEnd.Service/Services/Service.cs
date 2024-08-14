using Moviely.BackEnd.Core.Repositories;
using Moviely.BackEnd.Core.Services;
using Moviely.BackEnd.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviely.BackEnd.Service.Services
{
    public class Service<T> : IService<T> where T : class
    {


        private readonly IGenericRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;


        public Service(IGenericRepository<T> genericRepository, IUnitOfWork unitOfWork)
        {  
            _repository = genericRepository;
            _unitOfWork = unitOfWork;
        }



        public async Task AddAsync(T Entity)
        {
           await _repository.AddAsync(Entity);
           await _unitOfWork.CommitAsync();
        }

        public void Delete(T Entity)
        {
            _repository.Delete(Entity);
            _unitOfWork.Commit();
        }

        public Task<List<T>> FindByForeignIdEnties(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
           return _repository.GetAll();
        }

        public Task<T> GetByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public void Update(T Entity)
        {
            _repository.Update(Entity);
            _unitOfWork.Commit();
        }
    }
}
