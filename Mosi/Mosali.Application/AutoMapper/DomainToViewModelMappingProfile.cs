using AutoMapper;
using Mosali.Domaine.Entities;
using Survey.Application.ViewModels;

namespace Mosali.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile:Profile
    {
        public override string ProfileName {
            get { return "DomainToViewModelMapping"; }
        }
        public DomainToViewModelMappingProfile()
        {
         
            CreateMap<Employee, EmployeeViewModel>().ReverseMap();
           
         
            
        }
    }
}
