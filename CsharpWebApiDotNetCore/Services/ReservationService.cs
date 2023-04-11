using AutoMapper;
using CsharpWebApiDotNetCore.Models;
using CsharpWebApiDotNetCore.Models.DTO;
using CsharpWebApiDotNetCore.Repositories;

namespace CsharpWebApiDotNetCore.Services
{
    public class ReservationService:IReservationService
    {
        private readonly IReservationRepository _reservationrepository;
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerrepository;
        private readonly ILocationRepository _locationrepository;
        public ReservationService(IReservationRepository reservationRepository, ICustomerRepository customerRepository, ILocationRepository locationRepository, IMapper mapper)
        {
            _reservationrepository = reservationRepository;
            _mapper = mapper;
            _customerrepository = customerRepository;
            _locationrepository = locationRepository;
        }
        public async Task<ReservationResponseDTO> ReservationResponse(ReservationRequestDTO requestdto)
        {
            Customer customer = await _customerrepository.GetCustomer(requestdto.Email);
            if (customer == null)
            {
                customer = new Customer() { FirstName = requestdto.FirstName, LastName = requestdto.LastName, Email = requestdto.Email };
                await _customerrepository.CreateCustomer(customer);
            }
            Location location = await _locationrepository.GetLocationEager(requestdto.LocationId);
            int count = 0;
            for (var start = requestdto.StartDate.AddDays(1); start <= requestdto.EndDate.AddDays(1); start = start.AddDays(1))
            {
                count++;
            }
            Reservation reservation = new Reservation() { Customer = customer, Discount = requestdto.Discount ??= 0, StartDate = requestdto.StartDate, EndDate = requestdto.EndDate, Location = location };
            await _reservationrepository.CreateReservation(reservation);
            ReservationResponseDTO response = _mapper.Map<ReservationResponseDTO>(reservation);
            return response;        
        }
    }
}
