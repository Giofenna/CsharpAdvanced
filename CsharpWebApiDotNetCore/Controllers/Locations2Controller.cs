using AutoMapper;
using CsharpWebApiDotNetCore.Models;
using CsharpWebApiDotNetCore.Models.DTO;
using CsharpWebApiDotNetCore.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CsharpWebApiDotNetCore.Controllers
{
    [ApiVersion("2.0")]
    [ApiController]
    [Route("api/[controller]")]
    public class Locations2Controller : ControllerBase
    {
        private readonly ILocationService? _locationService;
        private readonly IMapper _mapper;
        // GET: api/<LocationsController>
        public Locations2Controller(ILocationService locationService, IMapper mapper)
        {
            _mapper = mapper;
            _locationService = locationService;
        }

      
        [MapToApiVersion("2.0")]
        [HttpGet]
        public IEnumerable<Location2Dto> GetLocations()
        {
            var locations = _locationService?.GetAllLocations();
            return locations.Select(l => _mapper.Map<Location2Dto>(l));
        }
        [MapToApiVersion("2.0")]    
        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Location>? Get()
        {

            return _locationService?.GetAllLocations();
        }

        // GET api/<LocationsController>/5
        [MapToApiVersion("2.0")]
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LocationsController>
        [MapToApiVersion("2.0")]
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LocationsController>/5
        [MapToApiVersion("2.0")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LocationsController>/5
        [MapToApiVersion("2.0")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
