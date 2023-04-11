using CsharpWebApiDotNetCore.Models.DTO;

namespace CsharpWebApiDotNetCore.Services
{
    public interface IReservationService
    {
        public Task<ReservationResponseDTO> ReservationResponse(ReservationRequestDTO request);
    }
}
