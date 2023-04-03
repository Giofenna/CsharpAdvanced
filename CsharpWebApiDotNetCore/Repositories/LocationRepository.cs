using CsharpWebApiDotNetCore.Data;
using CsharpWebApiDotNetCore.Models;

namespace CsharpWebApiDotNetCore.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly AirDBContext? _context;

        public LocationRepository(AirDBContext? context)
        {
            _context = context;
        }
        public IEnumerable<Location>? GetAllLocations()
        {
            return _context?.Location?.ToList();
        }
    }
}