using AutoMapper;
using CsharpWebApiDotNetCore.Models;
using CsharpWebApiDotNetCore.Models.DTO;
using CsharpWebApiDotNetCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CsharpWebApiDotNetCore.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    
    [Route("api/[controller]")]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationService? _locationService;
        private readonly IMapper _mapper;
        public LocationsController(ILocationService locationService, IMapper mapper)
        {
            _mapper = mapper;
            _locationService = locationService;
        }



        [MapToApiVersion("1.0")]
        [HttpGet]
        public async Task<IEnumerable<LocationResponse>> GetLocations()
        {
            var locations = await _locationService?.GetAllLocations();
            return locations.Select(l => _mapper.Map<LocationResponse>(l));
        }
        [HttpGet]
        [MapToApiVersion("1.0")]
        [Route("GetAll")]
        public async Task<IEnumerable<Location>>? Get()
        {

            return await _locationService.GetAllLocations();
        }
        [MapToApiVersion("1.0")]
        [HttpPost]
        [Route("Search")]
        public async Task<IEnumerable<LocationResponse2>> Search([FromBody(EmptyBodyBehavior = EmptyBodyBehavior.Allow)] SearchDTO? request)
        {
            var locations = await _locationService.GetFilteredLocations(request);

            return locations.Select(l => _mapper.Map<LocationResponse2>(l));

        }

        [MapToApiVersion("1.0")]
        [HttpGet]
        [Route("GetMaxPrice")]
        public async Task<MaxPriceDTO> GetMaxPrice()
        {
            var maxprice = await _locationService.GetMaxPrice();
            return maxprice;
        }

        [MapToApiVersion("1.0")]
        [HttpGet]
        [Route("GetDetails/{id}")]
        public async Task<LocationDetailDTO> Details(int id)
        {
            LocationDetailDTO locationdetails = await _locationService.GetLocationEager(id);
            return locationdetails;
        }

        [MapToApiVersion("1.0")]
        [HttpGet]
        [Route("UnAvailableDate/{id}")]
        public async Task<UnAvailableDatesDTO> UnAvailableDatesDTO(int id)
        {
            UnAvailableDatesDTO un = await _locationService.UnAvailableDatesDTO(id);
            return un;
        }
        //// GET api/<LocationsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<LocationsController>
        //[MapToApiVersion("1.0")]
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<LocationsController>/5
        //[MapToApiVersion("1.0")]
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<LocationsController>/5
        //[MapToApiVersion("1.0")]
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
