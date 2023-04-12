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
            CreateMap<Reservation, ReservationResponseDTO>()
                .ForMember(l => l.CustomerName, x => x.MapFrom(j => j.Customer.FirstName + " " + j.Customer.LastName))
                .ForMember(l => l.LocationName, x => x.MapFrom(j => j.Location.Title))
                .ForMember(l=>l.Price,x=>x.MapFrom(j=>j.EndDate.Subtract(j.StartDate).TotalDays * j.Location.PricePerDay));
        }

    }
}
