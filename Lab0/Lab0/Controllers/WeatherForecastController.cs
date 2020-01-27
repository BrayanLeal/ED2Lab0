using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab0.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Lab0.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly Data _data;
        public WeatherForecastController(Data data)
        {
            _data = new Data();
        }


        [HttpPost]

        public  ActionResult<Movie> Post([FromBody]Movie PMovie)
        {
           
            return PMovie;
        }

        [HttpGet]
        public List<Movie> Get(Movie NMovie)
        {
             return Data.Instance.movies;
            
        }
      
 
    }
}
