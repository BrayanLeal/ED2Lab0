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
       [HttpPost]
       
       public ActionResult<Movie> Post([FromBody]Movie PMovie)
        {
            
           Data.Instance.movies.Add(PMovie);
            //return CreatedAtRoute("Get",new { title =PMovie.Title.ToString()},PMovie);
            return PMovie;
        }

        [HttpGet]
        public List<Movie> Get(Movie NMovie)
        {
            return Data.Instance.movies;
            
        }
    }
}
