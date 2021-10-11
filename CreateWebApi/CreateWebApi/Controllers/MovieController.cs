using CreateWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CreateWebApi.Controllers
{
    public class MovieController : ApiController
    {
        [Route("movies/all")]
        [AcceptVerbs("GET")]
        public IHttpActionResult Get(int movieId)
        {
            Movie movie = MovieRepository.Get(movieId);

            if (movie == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(movie);
            }
        }
    }
}