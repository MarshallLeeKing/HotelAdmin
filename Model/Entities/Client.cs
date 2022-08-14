using System.Collections.Generic;

namespace HotelAdmin.Model.Entities
{
    internal class Client {
    
        int Id { get; set; }
        string ArrivedCity { get; set; }

        // связь один к одному
        int PeopleId { get; set; }
        People People { get; set; }

        // связь один ко многим
        List<Order> Orders { get; set; } = new List<Order>();
        List<Roommate> Roommates { get; set; } = new List<Roommate>();
        }
}