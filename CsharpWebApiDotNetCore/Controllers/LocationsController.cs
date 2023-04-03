using CsharpWebApiDotNetCore.Models;
using CsharpWebApiDotNetCore.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CsharpWebApiDotNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationService? _locationService;
        // GET: api/<LocationsController>
        public LocationsController(ILocationService locationService)
        {
            _locationService = locationService;
        }
        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Location>? Get()
        {

            return _locationService?.GetAllLocations();
        }

        // GET api/<LocationsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LocationsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LocationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LocationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
