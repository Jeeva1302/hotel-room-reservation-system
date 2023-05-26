using HotelRoomReservationSystem.Models;
using Microsoft.EntityFrameworkCore;
namespace HotelRoomReservationSystem.Repositories.HotelServices
{
    public class HotelRepository : IHotel
    {
        private readonly HotelContext _hotelContext;

        public HotelRepository(HotelContext con)
        {
            _hotelContext = con;
        }

        public IEnumerable<hotel> GetHotel()
        {
            try
            {
                return _hotelContext.Hotels.Include(x => x.Rooms).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to retrieve hotels.", ex);
            }
        }

        public hotel GetHotelById(int HotelId)
        {
            try
            {
                return _hotelContext.Hotels.FirstOrDefault(x => x.HotelId == HotelId);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to retrieve hotel by ID.", ex);
            }
        }

        public hotel PostHotel(hotel hotel)
        {
            try
            {
                _hotelContext.Hotels.Add(hotel);
                _hotelContext.SaveChanges();
                return hotel;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to create hotel.", ex);
            }
        }

        public hotel PutHotel(int HotelId, hotel hotel)
        {
            try
            {
                _hotelContext.Entry(hotel).State = EntityState.Modified;
                _hotelContext.SaveChanges();
                return hotel;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update hotel.", ex);
            }
        }

        public hotel DeleteHotel(int HotelId)
        {
            try
            {
                var hotel = _hotelContext.Hotels.Find(HotelId);
                _hotelContext.Hotels.Remove(hotel);
                _hotelContext.SaveChanges();
                return hotel;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete hotel.", ex);
            }
        }

        public hotel Puthotel(int hotelId, hotel hotel)
        {
            throw new NotImplementedException();
        }

        public hotel Posthotel(hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}
