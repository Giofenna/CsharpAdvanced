using CsharpWebApiDotNetCore.Models;
using CsharpWebApiDotNetCore.Repositories;
namespace CsharpWebApiDotNetCore.Services
{
    public class LocationService:ILocationService
    {
        private readonly ILocationRepository _locationRepository;

        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }
        
        public IEnumerable<Location> GetAllLocations()
        {
            return _locationRepository.GetAllLocations();
        }
    }
}
