using HotelRoomReservationSystem.Models;
using HotelRoomReservationSystem.Repositories.HotelServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelRoomReservationSystem.Controllers
{
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {

        private readonly IHotel hot;
        public HotelsController(IHotel hot)
        {
            this.hot = hot;
        }
        [HttpGet]
        public IEnumerable<hotel> Get()
        {
            return (IEnumerable<hotel>)hot.GetHotel();
        }

        [HttpGet("{HotelId}")]
        public hotel GetById(int HotelId)
        {
            return hot.GetHotelById(HotelId);
        }

        [HttpPost]
        public hotel PostHotel(hotel hotel)
        {
            return hot.PostHotel(hotel);
        }
        [HttpPut("{HotelId}")]
        public hotel PutHotel(int HotelId, hotel hotel)
        {
            return hot.PutHotel(HotelId, hotel);
        }
        [HttpDelete("{HotelId}")]
        public hotel DeleteHotel(int HotelId)
        {
            return hot.DeleteHotel(HotelId);
        }

    }
}
