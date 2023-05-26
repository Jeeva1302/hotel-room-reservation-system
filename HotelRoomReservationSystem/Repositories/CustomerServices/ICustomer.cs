using HotelRoomReservationSystem.Models;

namespace HotelRoomReservationSystem.Repositories.CustomerServices
{
    public interface ICustomer
    {
        public IEnumerable<Customer> GetCustomer();
        public Customer GetCustomerById(int CustomerId);
        public Customer PostCustomer(Customer customer);
        public Customer PutCustomer(int CustomerId, Customer customer);
        public Customer DeleteCustomer(int CustomerId);
        public IEnumerable<hotel> FilterHotels(string location);
        public int GetRoomCount(int RoomId, int HotelId);
        public IEnumerable<hotel> FilterPriceRange(decimal minPrice, decimal maxPrice);




    }
}
