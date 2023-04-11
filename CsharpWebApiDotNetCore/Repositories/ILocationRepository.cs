using CsharpWebApiDotNetCore.Models;

namespace CsharpWebApiDotNetCore.Repositories
{
    public interface ILocationRepository
    {
        public Task<IEnumerable<Location>>? GetAllLocations();

        public Task<Location>? GetLocation(int id);
        public Task<Location>? GetLocationEager(int id);
        public Task<Location> GetLocationWithReservations(int id);
    }
}
