namespace HotelAdmin.Model.Entities
{
    public class Roommate {

        public int Id { get; set; }

        // связь один ко многим
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}