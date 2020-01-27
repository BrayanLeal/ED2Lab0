using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab0.Models
{
    public class Data : HerData 
    {
        public Stack<Movie> Movies { get; set; }


        private static Data _instance ;
        public static Data Instance
        {
            get
            {
                if (_instance == null) _instance = new Data();
                return _instance;
            }
        }
        public List<Movie> movies = new List<Movie>();
        public Data()
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
            int cont = 1;
            foreach (var item in Movies)
            {
                temp.Add(item);
                cont++;
                if (cont > 10)
                {
                    break;
                }
            }
            return temp;
        }


    }
    public interface HerData
    {
        Stack<Movie> Movies { get; set; }
        void Create(Movie movie);
        List<Movie> Get();
    }
}
