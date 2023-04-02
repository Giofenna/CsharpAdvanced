using CsharpWebApiDotNetCore.Data;

namespace CsharpWebApiDotNetCore.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private readonly AirDBContext? _context;

        public ImageRepository(AirDBContext? context)
        {
            _context = context;
        }
    }
}