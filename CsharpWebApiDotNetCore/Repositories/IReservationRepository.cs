using CsharpWebApiDotNetCore.Models;
namespace CsharpWebApiDotNetCore.Repositories
{
    public interface IReservationRepository
    {
        public Task CreateReservation(Reservation reservation);
    }
}
