using CsharpWebApiDotNetCore.Data;
using CsharpWebApiDotNetCore.Models;
namespace CsharpWebApiDotNetCore.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly AirDBContext? _context;

        public ReservationRepository(AirDBContext? context)
        {
            _context = context;
        }
        public async Task CreateReservation(Reservation reservation)
        {
            
            await _context.Reservation.AddAsync(reservation);
            _context.SaveChanges();
        }
    }
}