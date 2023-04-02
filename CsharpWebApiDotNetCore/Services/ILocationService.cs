using CsharpWebApiDotNetCore.Models;

namespace CsharpWebApiDotNetCore.Services
{
    public interface ILocationService
    {
        public IEnumerable<Location> GetAllLocations();
    }
}
