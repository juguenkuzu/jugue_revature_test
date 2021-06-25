using Mosali.Domaine.Interfaces.Repositories;
using Mosali.Domaine.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mosali.Domaine.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;
        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }
        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public void AddRange(IEnumerable<TEntity> obj)
        {
            _repository.AddRange(obj);
        }

        public void Dispose()
        {

        }

        public IEnumerable<TEntity> GetAll()
        {
           return _repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

     

    }

}
