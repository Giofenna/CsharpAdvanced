namespace CsharpWebApiDotNetCore.Models.DTO
{
    public class LocationDetailDTO
    {
        public string? Title { get; set; }

        public string? SubTitle { get; set; }

        public string? Description { get; set; }

        public int Rooms { get; set; }

        public int NumberOfGuests { get; set; }

        public float PricePerDay { get; set; }

        public int Type { get; set; }

        public int Features { get; set; }

        public IEnumerable<ImagesCompDTO>? Images { get; set; }

        public LandlordCompDTO? Landlord { get; set; }
    }
}
