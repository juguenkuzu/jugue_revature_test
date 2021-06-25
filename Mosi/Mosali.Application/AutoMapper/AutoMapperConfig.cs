using AutoMapper;

namespace Mosali.Application.AutoMapper
{
    public class AutoMapperConfig: IAutoMapperConfig
    {
      

        public MapperConfiguration Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                    cfg.AddProfile<DomainToViewModelMappingProfile>();
                    cfg.AddProfile<ViewModelToDomainMappingProfile>();
            }
           );

            return config;
        }


    }
}
