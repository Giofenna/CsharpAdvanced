using CsharpWebApiDotNetCore.Models;
using CsharpWebApiDotNetCore.Repositories;
using CsharpWebApiDotNetCore.Models.DTO;
using AutoMapper;

namespace CsharpWebApiDotNetCore.Services
{
    public class LocationService:ILocationService
    {
        private readonly ILocationRepository _locationRepository;
        private readonly IMapper _mapper;

        public LocationService(ILocationRepository locationRepository, IMapper mapper)
        {
            _locationRepository = locationRepository;
            _mapper = mapper;
        }
        public async Task<LocationDetailDTO> GetDetails(int id)
        {
            var location = await _locationRepository.GetDetails(id);
            return _mapper.Map<LocationDetailDTO>(location);
        }

        public async Task<IEnumerable<Location>> GetAllLocations()
        {
            return await _locationRepository.GetAllLocations();
        }
        public async Task<MaxPriceDTO> GetMaxPrice()
        {
            var locations = await _locationRepository.GetAllLocations();
            var location = locations.First(x => x.PricePerDay == locations.Max(x => x.PricePerDay));
            return _mapper.Map<MaxPriceDTO>(location);
        }
        public async Task<IEnumerable<Location>> GetFilteredLocations(SearchDTO request)
        {
            var locations = await _locationRepository.GetAllLocations();
            if (request != null)
            {
                if(request.Features != null)
                {
                    locations = locations.Where(i => (int)i.Features == request.Features);
                }
                if(request.Type != null)
                {
                    locations = locations.Where(i => (int)i.Type == request.Type);
                }
                if (request.Rooms != null)
                {
                    locations = locations.Where(i => (int)i.Rooms >= request.Rooms);
                }
                if (request.MinPrice != null)
                {
                    locations = locations.Where(i => i.PricePerDay >= request.MinPrice);
                }
                if (request.MaxPrice != null)
                {
                    locations = locations.Where(i => i.PricePerDay <= request.MaxPrice);
                }

            }
            return locations;
        }

    }
}
