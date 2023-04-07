using CsharpWebApiDotNetCore.Models;
using CsharpWebApiDotNetCore.Models.DTO;
namespace CsharpWebApiDotNetCore.Services
{
    public interface ILocationService
    {
        public Task<IEnumerable<Location>> GetAllLocations();
        public Task<IEnumerable<Location>> GetFilteredLocations(SearchDTO request);
        public Task<MaxPriceDTO> GetMaxPrice();
        public Task<LocationDetailDTO> GetDetails(int id);
    }
}
