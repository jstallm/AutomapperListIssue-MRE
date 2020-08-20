using AutoMapper;
using WebApplication1.Controllers;
using WebApplication1.Models;

namespace WebApplication1.AutoMapper
{
    public class OuterSourceToOuterDest : Profile
    {
        public OuterSourceToOuterDest()
        {
            CreateMap<OuterSource, OuterDest>();
        }
    }

}
