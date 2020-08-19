using AutoMapper;
using WebApplication1.Controllers;
using WebApplication1.Models;

namespace WebApplication1.AutoMapper
{
    public class InputModelToDomainModel : Profile
    {
        public InputModelToDomainModel()
        {
            CreateMap<InputModel, DomainModel>();
        }
    }

}
