using CsharpWebApiDotNetCore.Models;
using CsharpWebApiDotNetCore.Models.DTO;
namespace CsharpWebApiDotNetCore.Services
{
    public interface ILocationService
    {
        public Task<IEnumerable<Location>> GetAllLocations();
        public Task<IEnumerable<Location>> GetFilteredLocations(SearchDTO request);
        public Task<MaxPriceDTO> GetMaxPrice();
        public Task<LocationDetailDTO> GetLocation(int id);
        public Task<LocationDetailDTO> GetLocationEager(int id);

        public Task<UnAvailableDatesDTO> UnAvailableDatesDTO(int Id); 
    }
}
