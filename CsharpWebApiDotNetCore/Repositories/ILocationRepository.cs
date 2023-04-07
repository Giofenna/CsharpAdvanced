using CsharpWebApiDotNetCore.Models;

namespace CsharpWebApiDotNetCore.Repositories
{
    public interface ILocationRepository
    {
        public Task<IEnumerable<Location>>? GetAllLocations();

        public Task<Location>? GetDetails(int id);
    }
}
