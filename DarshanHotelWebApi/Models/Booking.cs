using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DarshanHotelWebApi.Models
{

    public class Booking : IEntity
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public string BookedBy { get; set; }

        public DateTime BookingDate { get; set; }
        public DateTime CheckInDate { get; set; }
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public string BookingSource { get; set; }

        public string CustName { get; set; }
        public string CustMobile { get; set; }
        public string CustCity { get; set; }
        public int CustAdult { get; set; }
        public int CustChild { get; set; }

        public int RoomTariff { get; set; }
        public int GST { get; set; }
        public int Total { get; set; }
        public int ExtraBed { get; set; }
        public int Discount { get; set; }
        public int GrossTotal { get; set; }
        public int PaidAmount { get; set; }
        public int BalanceAmount { get; set; }

        public string ActionStatus { get; set; }
        public DateTime ActionTimeStamp { get; set; }


    }
}