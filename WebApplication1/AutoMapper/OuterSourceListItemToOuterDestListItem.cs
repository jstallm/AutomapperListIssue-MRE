using AutoMapper;
using WebApplication1.Controllers;
using WebApplication1.Models;

namespace WebApplication1.AutoMapper
{
    public class OuterSourceListItemToOuterDestListItem : Profile
    {
        public OuterSourceListItemToOuterDestListItem()
        {
            CreateMap<OuterSourceListItem, OuterDestListItem>();
        }
    }

}
