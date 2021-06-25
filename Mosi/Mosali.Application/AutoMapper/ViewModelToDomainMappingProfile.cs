using AutoMapper;
using Mosali.Domaine.Entities;
using Survey.Application.ViewModels;

namespace Mosali.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile:Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMapping"; }
        }
        public ViewModelToDomainMappingProfile()
        {
           
            CreateMap<EmployeeViewModel, Employee>().ReverseMap();
         
        }
    }
}
