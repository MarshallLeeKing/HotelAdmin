using System;
using System.Collections.Generic;

namespace HotelAdmin.Model.Entities
{
    internal class Order {

        int Id { get; set; }
        DateTime DateIn { get; set; }
        DateTime DateOut { get; set; }
        double? Summ { get; set; }

        // связь один ко многим
        int ClientId { get; set; }
        Client Client { get; set; }

        int RoomId { get; set; }
        Room Room { get; set; }

        // связь многие ко многим
        List<Roommate> Rommates { get; set; } = new List<Roommate>();
    }
}