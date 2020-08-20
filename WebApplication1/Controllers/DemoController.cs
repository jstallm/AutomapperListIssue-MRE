using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : ControllerBase
    {

        private readonly IMapper _mapper;

        public DemoController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var inputModel = new OuterSource() { ID = 1};
            inputModel.List = new List<OuterSourceListItem>();
            inputModel.List.Add(new OuterSourceListItem() { Name = "aaa", Desc = "dddd" });
            var domain = _mapper.Map<OuterDest>(inputModel);

            return Ok(domain);
        }
    }
}
