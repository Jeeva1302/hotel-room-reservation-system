using HotelRoomReservationSystem.Models;

namespace HotelRoomReservationSystem.Repositories.HotelServices
{
    public interface IHotel
    {
        public IEnumerable<hotel> GetHotel();
        public hotel GetHotelById(int HotelId);
        public hotel PostHotel(hotel hotel);
        public hotel PutHotel(int HotelId, hotel hotel);
        public hotel DeleteHotel(int HotelId);
        hotel Puthotel(int hotelId, hotel hotel);
        hotel Posthotel(hotel hotel);
    }
}
