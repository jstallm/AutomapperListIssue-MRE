using AutoMapper;

namespace WebApplication1.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new InputModelToDomainModel());
                //cfg.ValidateInlineMaps = false;
                //cfg.AddProfile(new MessageResourceToMessageDomain());
            });
        }
    }
}