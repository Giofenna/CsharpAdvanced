using CsharpWebApiDotNetCore.Models;

namespace CsharpWebApiDotNetCore.Services
{
    public class LocationService:ILocationService
    {

        private readonly ILocationService _locationService;
        public LocationService(ILocationService locationService)
        {
            _locationService = locationService;
        }
        public IEnumerable<Location> GetAllLocations()
        {
            return _locationService.GetAllLocations();
        }
    }
}
