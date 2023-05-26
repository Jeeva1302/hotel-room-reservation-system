using HotelRoomReservationSystem.Models;
using HotelRoomReservationSystem.Repositories.RoomServices.HotelManagement.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelRoomReservationSystem.Controllers
{
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoom r;
        public RoomsController(IRoom r)
        {
            this.r = r;
        }
        [HttpGet]
        public IEnumerable<Room> Get()
        {
            return r.GetRoom();
        }

        [HttpGet("{RoomId}")]
        public Room GetById(int RoomId)
        {
            return r.GetRoomById(RoomId);
        }

        [HttpPost]
        public Room PostRoom(Room room)
        {
            return r.PostRoom(room);
        }
        [HttpPut("{RoomId}")]
        public Room PutRoom(int RoomId, Room room)
        {
            return r.PutRoom(RoomId, room);
        }
        [HttpDelete("{RoomId}")]
        public Room DeleteRoom(int RoomId)
        {
            return r.DeleteRoom(RoomId);
        }

    }
}
