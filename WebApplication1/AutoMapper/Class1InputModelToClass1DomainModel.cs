using AutoMapper;
using WebApplication1.Controllers;
using WebApplication1.Models;

namespace WebApplication1.AutoMapper
{
    public class Class1InputModelToClass1DomainModel : Profile
    {
        public Class1InputModelToClass1DomainModel()
        {
            CreateMap<Class1InputModel, Class1DomainModel>();
        }
    }

}
