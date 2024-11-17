using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using WebAPI_01.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        static List<Movie> Movies = new List<Movie>();

        // GET: api/<MoviesController>
        [HttpGet]
        public ActionResult<IEnumerable<Movie>> Get()
        {
            return Ok(Movies);
        }

        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public Movie? Get(int id)
        {
            return Movies.FirstOrDefault(m => m.Id == id);
        }

        // POST api/<MoviesController>
        [HttpPost]
        public void Post([FromBody] Movie value)
        {
            Movies.Add(value);
        }

        // PUT api/<MoviesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Movie value)
        {
            Movie? movie = Movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                Movies.Add(value);
                return;
            }
            movie.Title = value.Title;
            movie.Year = value.Year;

        }

        // DELETE api/<MoviesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Movie? movie = Movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return;
            }
            Movies.Remove(movie);
        }
    }
}
