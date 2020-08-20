using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly IMapper _mapper;       

        public WeatherForecastController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var inputModel = new InputModel();
            inputModel.MyList = new List<Class1InputModel>();
            inputModel.MyList.Add(new Class1InputModel() { Name = "aaa", Description = "dddd" });
            inputModel.SomeAggregateProp = "123";
            var domain = _mapper.Map<DomainModel>(inputModel);

            return Ok(domain);
        }
    }
}
