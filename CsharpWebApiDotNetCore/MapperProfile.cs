using AutoMapper;
using CsharpWebApiDotNetCore.Models;
using CsharpWebApiDotNetCore.Models.DTO;

namespace Services
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        { 
           CreateMap<Location, LocationDto>()
            .ForMember(location => location.ImageURL, i => i.MapFrom(j => j.Images!.Where(j => j.IsCover == true).First().Url));
            CreateMap<Location, Location2Dto>()
           .ForMember(location => location.ImageURL, i => i.MapFrom(j => j.Images!.Where(j => j.IsCover == true).First().Url))
           .ForMember(l => l.Price, x => x.MapFrom(z => z.PricePerDay)); ;
        }
        
    }
}
