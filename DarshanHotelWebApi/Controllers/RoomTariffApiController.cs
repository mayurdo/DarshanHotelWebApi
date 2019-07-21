using DarshanHotelWebApi.DbService;
using DarshanHotelWebApi.Models;

namespace DarshanHotelWebApi.Controllers
{
    public class RoomTariffApiController : BaseApiController<RoomTariff>
    {
        private RoomTariffService _roomTariffService;
        public RoomTariffApiController()
        {
            _roomTariffService = new RoomTariffService();
            _dataAccessService = _roomTariffService;
        }      
    }
}
