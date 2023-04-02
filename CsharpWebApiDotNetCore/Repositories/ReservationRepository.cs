using CsharpWebApiDotNetCore.Data;

namespace CsharpWebApiDotNetCore.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly AirDBContext? _context;

        public ReservationRepository(AirDBContext? context)
        {
            _context = context;
        }
    }
}