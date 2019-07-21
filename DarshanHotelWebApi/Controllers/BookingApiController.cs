using DarshanHotelWebApi.DbService;
using DarshanHotelWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DarshanHotelWebApi.Controllers
{
    public class BookingApiController : BaseApiController<Booking>
    {
        private BookingService _bookingService;
        public BookingApiController()
        {
            _bookingService = new BookingService();
            _dataAccessService = _bookingService;
        }

        [Route("api/BookingApi/GetBookingByDate/{startDate}/{endDate}")]
        [HttpGet]
        public virtual IEnumerable<Booking> GetBookingByDate(DateTime startDate, DateTime endDate)
        {
            return _bookingService.GetBookingByDate(startDate,endDate);
        }
    }
}
