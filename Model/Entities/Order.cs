using System;
using System.Collections.Generic;

namespace HotelAdmin.Model.Entities
{
    public class Order {

        public int Id { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public double? Summ { get; set; }

        // связь один ко многим
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        public int RoomId { get; set; }
        public virtual Room Room { get; set; }

        public virtual List<Roommate> Rommates { get; set; } = new List<Roommate>();
    }
}