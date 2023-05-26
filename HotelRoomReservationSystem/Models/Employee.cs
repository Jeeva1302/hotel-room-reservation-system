using System.ComponentModel.DataAnnotations;

namespace HotelRoomReservationSystem.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public hotel? Hotel { get; set; }
    }
}
