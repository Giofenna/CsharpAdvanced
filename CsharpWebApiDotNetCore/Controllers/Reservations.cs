using AutoMapper;
using CsharpWebApiDotNetCore.Models.DTO;
using CsharpWebApiDotNetCore.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CsharpWebApiDotNetCore.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/[controller]")]
    public class Reservations : ControllerBase
    {
        private readonly IReservationService _reservationService;
        private readonly IMapper _mapper;
        public Reservations(IReservationService reservationService, IMapper mapper)
        {
            _mapper = mapper;
            _reservationService = reservationService;
        }
        // GET: api/<Reservations>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<Reservations>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<Reservations>
        [ApiVersion("1.0")]
        [HttpPost]
        public async Task<ReservationResponseDTO> Post([FromBody] ReservationRequestDTO requestdto)
        {
            
            ReservationResponseDTO response = await _reservationService.ReservationResponse(requestdto);

            return response;

        }

        //// PUT api/<Reservations>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<Reservations>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
