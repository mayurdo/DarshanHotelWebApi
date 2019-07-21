namespace DarshanHotelWebApi.Models
{
    public interface IEntity
    {
        int Id { get; set; }

        bool IsDeleted { get; set; }
    }
}