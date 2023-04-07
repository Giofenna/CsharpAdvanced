using CsharpWebApiDotNetCore.Data;
using CsharpWebApiDotNetCore.Models;
using Microsoft.EntityFrameworkCore;

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
            return _context?.Location.Include(data=>data.Landlord).ThenInclude(data=>data.Avatar).Include(data=>data.Images).ToList();
           
        }
    }
}