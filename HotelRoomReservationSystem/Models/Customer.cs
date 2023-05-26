using System.ComponentModel.DataAnnotations;

namespace HotelRoomReservationSystem.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }

        public int CustomerPhone { get; set; }

        public hotel? Hotel { get; set; }


    }
}
