using Microsoft.EntityFrameworkCore;
using CsharpWebApiDotNetCore.Models;
using CsharpWebApiDotNetCore.Repositories;
using System.ComponentModel.DataAnnotations;

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
                modelBuilder.Entity<Landlord>().HasData(new { Id = 1, Age = 1, AvatarId = 21, FirstName = "Jeffry", LastName = "Bahmer" }
                , new { Id = 2, Age = 1, AvatarId = 22, FirstName = "Deffry", LastName = "Dahmer" }, new { Id = 3, Age = 1, AvatarId = 23, FirstName = "Teffry", LastName = "Tahmer" });
                modelBuilder.Entity<Location>().HasData(new { Id = 1, Rooms = 2, NumberOfGuests = 4, Title = "House1", Description = "Description1", PricePerDay = (float)20, SubTitle = "SubTitle1", Features = (Features)1, Type = LocationType.Appartment, LandlordId = 1 }
                , new { Id = 2, Rooms = 2, NumberOfGuests = 4, Title = "House2", Description = "Description2", PricePerDay = (float)30, SubTitle = "SubTitle2", Features = (Features)2, Type = LocationType.Chalet, LandlordId = 1 }
                , new { Id = 3, Rooms = 2, NumberOfGuests = 4, Title = "House3", Description = "Description3", PricePerDay = (float)31, SubTitle = "SubTitle3", Features = (Features)3, Type = LocationType.House, LandlordId = 1 }
                , new { Id = 4, Rooms = 2, NumberOfGuests = 4, Title = "House4", Description = "Description4", PricePerDay = (float)32, SubTitle = "SubTitle4", Features = (Features)4, Type = LocationType.Room, LandlordId = 1 }
                , new { Id = 5, Rooms = 2, NumberOfGuests = 4, Title = "House5", Description = "Description5", PricePerDay = (float)33, SubTitle = "SubTitle5", Features = (Features)5, Type = LocationType.Hotel, LandlordId = 1 }
                , new { Id = 6, Rooms = 2, NumberOfGuests = 4, Title = "House6", Description = "Description6", PricePerDay = (float)34, SubTitle = "SubTitle6", Features = (Features)6, Type = LocationType.Appartment, LandlordId = 1 }
                , new { Id = 7, Rooms = 2, NumberOfGuests = 4, Title = "House7", Description = "Description7", PricePerDay = (float)35, SubTitle = "SubTitle7", Features = (Features)7, Type = LocationType.Cottage, LandlordId = 1 }
                , new { Id = 8, Rooms = 2, NumberOfGuests = 4, Title = "House8", Description = "Description8", PricePerDay = (float)36, SubTitle = "SubTitle8", Features = (Features)8, Type = LocationType.Room, LandlordId = 1 }
                , new { Id = 9, Rooms = 2, NumberOfGuests = 4, Title = "House9", Description = "Description9", PricePerDay = (float)37, SubTitle = "SubTitle9", Features = (Features)9, Type = LocationType.Hotel, LandlordId = 1 }
                , new { Id = 10, Rooms = 2, NumberOfGuests = 4, Title = "House10", Description = "Description10", PricePerDay = (float)38, SubTitle = "SubTitle10", Features = (Features)10, Type = LocationType.Cottage, LandlordId = 1 });
                modelBuilder.Entity<Image>().HasData(new { Id = 1, Url = "https://th.bing.com/th/id/OIP.4XB8NF1awQyApnQDDmBmQwHaEo?pid=ImgDet&rs=1", LocationId = 1, IsCover = true }
                , new { Id = 2, Url = "https://th.bing.com/th/id/R.7a5b8b8f2c06d86438fa0ca1d1a6e81e?rik=6mW1IbIQA718KQ&pid=ImgRaw&r=0", LocationId = 1, IsCover = false }
                , new { Id = 3, Url = "https://th.bing.com/th/id/OIP.rt-pujAJJlfsYntGE4rRAgHaE7?pid=ImgDet&rs=1", LocationId = 2, IsCover = true }
                , new { Id = 4, Url = "https://th.bing.com/th/id/R.1ac8616cc26c5ffa5d4a124e068c447d?rik=Q3ad8plACqWAMQ&riu=http%3a%2f%2flovelyfotos.l.o.pic.centerblog.net%2fo%2f98a8ed98.jpg&ehk=oMZ4%2bUZ%2b2P7UvBelRgLJi%2fXMGMrpqfqtm%2bTC58Gqtbg%3d&risl=&pid=ImgRaw&r=0", LocationId = 2, IsCover = false }
                , new { Id = 5, Url = "https://miro.medium.com/v2/resize:fit:3840/1*xMuIOwjliGUPjkzukeWKfw.jpeg", LocationId = 3, IsCover = true }
                , new { Id = 6, Url = "https://th.bing.com/th/id/OIP.L51qzGCLtslIZn42Q0BFhgHaE7?pid=ImgDet&rs=1", LocationId = 3, IsCover = false }
                , new { Id = 7, Url = "https://pixy.org/src/21/219269.jpg", LocationId = 4, IsCover = true }
                , new { Id = 8, Url = "https://th.bing.com/th/id/R.551cf68432c7dd0c1ddfebb77c484b16?rik=4BRITn7IBb7E5A&riu=http%3a%2f%2fthewowstyle.com%2fwp-content%2fuploads%2f2015%2f07%2f3d-only-natural-backgrounds-wallpapers.jpg&ehk=PKY8ZDTMjVdIJyFK3s1z1hshGDDLPv3Igu1kxcN3yH8%3d&risl=&pid=ImgRaw&r=0", LocationId = 4, IsCover = false }
                , new { Id = 9, Url = "https://images.toucharger.com/img/graphiques/fonds-d-ecran/nature--paysages/coucher-de-soleil/polynesie.72440.jpg", LocationId = 5, IsCover = true }
                , new { Id = 10, Url = "https://www.freepsdbazaar.com/wp-content/uploads/2020/06/sky-night/night-sky-049.jpg", LocationId = 5, IsCover = false }
                , new { Id = 11, Url = "https://th.bing.com/th/id/R.35b7cf10203ae316c59e65b9f0c6d60d?rik=PEZxCxVcGh5lEw&riu=http%3a%2f%2fs1.picswalls.com%2fwallpapers%2f2017%2f12%2f11%2fnature-desktop-background_123026895_313.jpg&ehk=rvr98svQL12hNeYouWPK7AvyXVnHaRJWDvovllsJxRs%3d&risl=1&pid=ImgRaw&r=0", LocationId = 6, IsCover = true }
                , new { Id = 12, Url = "https://images.toucharger.com/img/graphiques/fonds-d-ecran/nature-paysages/coucher-de-soleil/coucher-de-soleil.74120.jpg", LocationId = 6, IsCover = false }
                , new { Id = 13, Url = "https://th.bing.com/th/id/R.0d045617037f9cef063d1a9dfe2646b7?rik=EswZh150nqhxsg&riu=http%3a%2f%2fwww.snut.fr%2fwp-content%2fuploads%2f2015%2f07%2fimage-de-fleur-6.jpg&ehk=M9uLBYMHQgtcByG2fGYQSKyylapb%2bfCApnNYShcBdfE%3d&risl=&pid=ImgRaw&r=0", LocationId = 7, IsCover = true }
                , new { Id = 14, Url = "https://th.bing.com/th/id/R.3bcb9885029ffb81f58fb4a46c6d854f?rik=caTmTHH%2bNuWv1w&riu=http%3a%2f%2fgetwallpapers.com%2fwallpaper%2ffull%2f8%2fd%2f1%2f798741-download-free-awesome-nature-backgrounds-1920x1080-for-tablet.jpg&ehk=%2fu8xawhlqhlABfauhjBvJm3YUpEq5Vjqj2FfHAGm%2bj8%3d&risl=&pid=ImgRaw&r=0", LocationId = 7, IsCover = false }
                , new { Id = 15, Url = "https://cdn.wallpapersafari.com/43/42/IwWBH3.jpg", LocationId = 8, IsCover = true }
                , new { Id = 16, Url = "https://www.esa.int/var/esa/storage/images/esa_multimedia/images/2017/11/autumn_fireball/17255671-1-eng-GB/Autumn_fireball.jpg", LocationId = 8, IsCover = false }
                , new { Id = 17, Url = "https://goldwallpapers.com/uploads/posts/jpeg-wallpapers/jpeg_wallpapers_026.jpg", LocationId = 9, IsCover = true }
                , new { Id = 18, Url = "https://images4.alphacoders.com/115/thumb-1920-115716.jpg", LocationId = 9, IsCover = false }
                , new { Id = 19, Url = "https://th.bing.com/th/id/OIP.4XB8NF1awQyApnQDDmBmQwHaEo?pid=ImgDet&rs=1", LocationId = 10, IsCover = true }
                , new { Id = 20, Url = "https://www.imagelighteditor.com/img/bg-after.jpg", LocationId = 10, IsCover = false }
                , new { Id = 21, Url = "https://www.pixelstalk.net/wp-content/uploads/2016/06/Free-Download-HD-Country-Image.jpg", IsCover = false }
                , new { Id = 22, Url = "https://i.ytimg.com/vi/xS-gJydZXuM/maxresdefault.jpg", IsCover = false }
                , new { Id = 23, Url = "https://www.wallpapertip.com/wmimgs/8-82164_soothing-background.jpg", IsCover = false });
                modelBuilder.Entity<Customer>().HasData(new Customer() { Id = 1, Email = "test@test.nl", FirstName = "Test", LastName = "Test" });
                modelBuilder.Entity<Reservation>().HasData(new { CustomerId = 1, Id = 1, Discount = (float)0, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(5), LocationId = 1 });
            }
        }

    }

}