using CsharpWebApiDotNetCore.Data;

namespace CsharpWebApiDotNetCore.Repositories
{
    public class LandlordRepository:ILandordRepository
    {
        private readonly AirDBContext? _context;

        public LandlordRepository(AirDBContext? context)
        {
            _context = context;
        }
    }
}
