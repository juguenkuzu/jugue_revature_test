

using Mosali.Domaine.Entities;
using Mosali.Domaine.Interfaces.Repositories;
using Mosali.Domaine.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mosali.Domaine.Services
{
    public class EmployeeService :  ServiceBase<Employee>, IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
            : base(employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
       
    }
}
