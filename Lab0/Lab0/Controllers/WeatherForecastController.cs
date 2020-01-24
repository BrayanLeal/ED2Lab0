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
        //public Stack<Movie> Movies { get; set; }
        /*public Movie()
        {
            Movies = new Stack<Movie>();
        }*/
        [HttpGet]
        public List<Movie> Get(Movie NMovie)
        {
            return Data.Instance.movies;
            
        }
        //stack 
        public Stack<Movie> Movies { get; set; }
        public MovieSet()
        {
            Movies = new Stack<Movie>();
        }
        public void Create(Movie movie)
        {
            Movies.Push(movie);
        }
        public List<Movie> Get()
        {
            List<Movie> temp = new List<Movie>();
            int aux = 1;
            foreach (var item in Movies)
            {
                temp.Add(Movies.Peek());
                aux++;
                if (aux>10)
                {
                    break;
                }

            }
            return temp;
        }
    }
}
