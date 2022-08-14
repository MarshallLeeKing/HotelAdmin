using System.Collections.Generic;

namespace HotelAdmin.Model.Entities
{
    public class Client {
    
        public int Id { get; set; }
        public string ArrivedCity { get; set; }

        // связь один к одному
        public int PeopleId { get; set; }
        public virtual People People { get; set; }

        // связь один ко многим
        public virtual List<Order> Orders { get; set; } = new List<Order>();
        public virtual List<Roommate> Roommates { get; set; } = new List<Roommate>();
        }
}