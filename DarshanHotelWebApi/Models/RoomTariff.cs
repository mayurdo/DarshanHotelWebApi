namespace DarshanHotelWebApi.Models
{
    public class RoomTariff : IEntity
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public string RoomType { get; set; }

        public int Reception { get; set; }
        public int Fortune4 { get; set; }
        public int Online { get; set; }
    }
}