using DarshanHotelWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DarshanHotelWebApi.DbService
{

    public class BookingService : BaseDbService<Booking>
    {
        public virtual List<Booking> GetBookingByDate(DateTime startDate, DateTime endDate)
        {
            using (var db = new DatabaseContext())
            {
                var list = db.Set<Booking>().Where(x => !x.IsDeleted && x.CheckInDate >= startDate && x.CheckInDate <= endDate).ToList();
                return list;
            }
        }
    }
}