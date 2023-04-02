using CsharpWebApiDotNetCore.Models;
using Microsoft.EntityFrameworkCore;
namespace CsharpWebApiDotNetCore.Data
{
    public class AirDBContext:DbContext
    {
        public AirDBContext(DbContextOptions<AirDBContext> options) : base(options) { }
        public DbSet<Landlord>? Landlord { get; set; }

        public DbSet<Customer>? Customer { get; set; }

        public DbSet<Image>? Images { get; set; }

        public DbSet<Location>? Locations { get; set; }

        public DbSet<Reservation>? Reservations { get; set; }
    }
}
