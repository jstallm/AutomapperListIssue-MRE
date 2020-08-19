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
    public static class MappingExpressionExtensions
    {
        public static IMappingExpression<TSource, TDest> IgnoreAllUnmapped<TSource, TDest>(this IMappingExpression<TSource, TDest> expression)
        {
            expression.ForAllMembers(opt => opt.Ignore());
            return expression;
        }
    }
}
