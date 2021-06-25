using AutoMapper;
using Mosali.Application.AutoMapper;
using Mosali.Application.Interface;
using Mosali.Application.Services;
using Mosali.Domaine.Entities;
using Mosali.Domaine.Interfaces.Services;
using Mosali.Exceptions;
using Survey.Application.Validators;
using Survey.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace Mosali.Application.Validators
{
    public class EmployeeAppService:  AppServiceBase<Employee>, IEmployeeAppService
    {
        private readonly IEmployeeService  _employeeService ;
        private IMapper _imapper;
        private readonly IAutoMapperConfig _autoMapperConfig;


        public EmployeeAppService(IEmployeeService employeeService, IAutoMapperConfig autoMapperConfig)
            :base(employeeService)
        {
            _employeeService = employeeService;
            _autoMapperConfig = autoMapperConfig;

        }

        public void Ajouter(EmployeeViewModel obj)
        {
            EmployeeValidator  validator = new EmployeeValidator();
            var validador = validator.Validate(obj);
            if (validador.IsValid)
            {

                _imapper = _autoMapperConfig.Configure().CreateMapper();
                var objMappe = _imapper.Map<EmployeeViewModel, Employee>(obj);
                try
                {
                    _employeeService.Add(objMappe);
                    
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            else
            {
                throw new MosaliException("Erreur de Validation", validador.Errors);
            }
            
        }

        public void MisAJour(EmployeeViewModel obj)
        {
            throw new System.NotImplementedException();
        }

        public EmployeeViewModel ObtenirParId(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<EmployeeViewModel> ObtenirParUserId(int userId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<EmployeeViewModel> ObtenirTout()
        {
          
            _imapper = _autoMapperConfig.Configure().CreateMapper();
          //  var employeeList = _employeeService.GetAll();
            //var employeeViewModelList = _imapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(employeeList);
            // return employeeViewModelList;
            return new List<EmployeeViewModel>() { new EmployeeViewModel() { EmployeeId=1,
                                                                             FirstName="Jugue",
                                                                             LastName="Nkuzu",
                                                                             OtherDetails="Le nouveau americain"},
                                                   new EmployeeViewModel() { EmployeeId=2,
                                                                             FirstName="Sandra",
                                                                             LastName="Bilonda",
                                                                             OtherDetails="La Congolaise"}};

        }

        public void Supprimer(EmployeeViewModel obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
