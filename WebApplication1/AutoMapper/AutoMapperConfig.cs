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
                cfg.AddProfile(new Class1InputModelToClass1DomainModel());
            });
        }
    }
}