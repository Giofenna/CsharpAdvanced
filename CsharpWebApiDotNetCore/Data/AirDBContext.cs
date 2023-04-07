using Microsoft.EntityFrameworkCore;
using CsharpWebApiDotNetCore.Models;


namespace CsharpWebApiDotNetCore.Data
{
    public class AirDBContext : DbContext
    {
        public AirDBContext(DbContextOptions<AirDBContext> options)
            : base(options)
        {
        }

        public DbSet<Landlord> Landlord { get; set; }

        public DbSet<Location> Location { get; set; }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Reservation> Reservation { get; set; }

        public DbSet<Image> Image { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new DbInitializer(modelBuilder).Seed();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=CSharpWebApiDotNetCore.Data;Integrated Security=SSPI;");
            base.OnConfiguring(optionsBuilder);

        }

        public class DbInitializer
        {
            private readonly ModelBuilder modelBuilder;

            public DbInitializer(ModelBuilder modelBuilder)
            {
                this.modelBuilder = modelBuilder;
            }
            public void Seed()
            {
                modelBuilder.Entity<Landlord>().HasData(new { Id = 1, Age = 1 , AvatarId= 1, FirstName = "Jeffry", LastName = "Bahmer"});
                modelBuilder.Entity<Location>().HasData(new  { Id = 1, Rooms = 2, NumberOfGuests = 4, Title = "Title", Description = "Description", PricePerDay = (float) 20, SubTitle = "SubTitle", Features =(Features) 0 , Type = LocationType.Cottage, LandlordId = 1});
                modelBuilder.Entity<Location>().HasData(new  { Id = 2, Rooms = 2, NumberOfGuests = 4, Title = "Title", Description = "Description", PricePerDay = (float ) 30, SubTitle = "SubTitle", Features = (Features) 0 , Type = LocationType.Cottage, LandlordId = 1});
                modelBuilder.Entity<Image>().HasData(new Image() { Id = 2, Url = "https://th.bing.com/th/id/OIP.4XB8NF1awQyApnQDDmBmQwHaEo?pid=ImgDet&rs=1", LocationId = 2 , IsCover = true });
                modelBuilder.Entity<Image>().HasData(new Image() { Id = 1, Url = "https://th.bing.com/th/id/OIP.4XB8NF1awQyApnQDDmBmQwHaEo?pid=ImgDet&rs=1", LocationId = 1 , IsCover = true });
            }
        }
        
    }

}