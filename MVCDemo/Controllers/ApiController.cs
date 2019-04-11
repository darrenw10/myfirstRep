using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCDemo.Controllers
{
    [Route("/Api/v1")]
    public class ApiController : Controller
    {
        private MovieDataSource.DataSource dataSource = new MovieDataSource.DataSource();

        [HttpGet("Movies")]
        public List<MovieDataSource.Movie> Movies()
        {
            return dataSource.GetAllMovies().Take(30).ToList();
        }

        [HttpGet("Movies/{movieId}")]
        public IActionResult Movies(int movieId)
        {
            var movie = dataSource.GetAllMovies().SingleOrDefault(m => m.ID == movieId);

            if (movie != null)
                return new ObjectResult(dataSource.GetMovieById(movieId));
            else
                return NotFound();
            //return StatusCode(404);
        }
    }
}
