using CsharpWebApiDotNetCore.Models;

namespace CsharpWebApiDotNetCore.Repositories
{
    public interface ILocationRepository
    {
        public IEnumerable<Location>? GetAllLocations();
    }
}
