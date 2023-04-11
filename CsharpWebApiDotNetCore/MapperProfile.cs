using AutoMapper;
using CsharpWebApiDotNetCore.Models;
using CsharpWebApiDotNetCore.Models.DTO;

namespace Services
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        { 
           CreateMap<Location, LocationResponse>()
            .ForMember(location => location.ImageURL, i => i.MapFrom(j => j.Images!.Where(j => j.IsCover == true).First().Url));
            CreateMap<Location, MaxPriceDTO>()
            .ForMember(location => location.Price, x => x.MapFrom(y => y.PricePerDay));
            CreateMap<Location, LocationResponse2>()
           .ForMember(location => location.ImageURL, i => i.MapFrom(j => j.Images!.Where(j => j.IsCover == true).First().Url))
           .ForMember(l => l.Price, x => x.MapFrom(z => z.PricePerDay));
            CreateMap<Image, ImagesCompDTO>();
            CreateMap<Landlord, LandlordCompDTO>()
                .ForMember(l => l.Avatar, x => x.MapFrom(y => y.Avatar!.Url))
                .ForMember(l => l.Name, x => x.MapFrom(y => y.FirstName + " " + y.LastName));
            CreateMap<Location, LocationDetailDTO>();
            CreateMap<ReservationRequestDTO, Reservation>();
            CreateMap<Reservation, ReservationResponseDTO>();
        }

    }
}
