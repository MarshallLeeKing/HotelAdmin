namespace HotelAdmin.Model.Entities
{
    internal class Roommate {

        int Id { get; set; }

        // связь один ко многим
        int OrderId { get; set; }
        Order Order { get; set; }

        int ClientId { get; set; }
        Client Client { get; set; }
    }
}