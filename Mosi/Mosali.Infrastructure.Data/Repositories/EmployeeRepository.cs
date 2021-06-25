using Mosali.Domaine.Entities;
using Mosali.Domaine.Interfaces.Repositories;
using System.Collections.Generic;

namespace Mosali.Infrastructure.Data.Repositories
{
    public class EmployeeRepository : RepositoryBase, IEmployeeRepository, IRepositoryBase<Employee>
    {
        public void Add(Employee obj)
        {
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            throw new System.NotImplementedException();
        }

        public void AddRange(IEnumerable<Employee> obj)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Employee GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Employee obj)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Employee obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
