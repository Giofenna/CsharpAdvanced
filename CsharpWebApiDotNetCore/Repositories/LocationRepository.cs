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
        public async Task<IEnumerable<Location>>? GetAllLocations()
        {
           return await _context.Location.Include(data=>data.Landlord).ThenInclude(data=>data.Avatar).Include(data=>data.Images).ToListAsync();
           
        }
        public async Task<Location> GetLocationEager(int id)
        {
            return await _context.Location.Include(l => l.Landlord).ThenInclude(x => x!.Avatar).Include(i => i.Images).FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<Location> GetLocationWithReservations(int id)
        {
            return await _context.Location.Include(l => l.Reservations).FirstOrDefaultAsync(i=> i.Id== id);
        }
        public async Task<Location> GetLocation(int id)
        {
            return await _context.Location.FindAsync(id);
        }
    }
}