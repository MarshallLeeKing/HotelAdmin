using System;
using System.Collections.Generic;

namespace HotelAdmin.Model.Entities
{
    public class PriceGroup {
    
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime DateStart { get; set; }

        // связь один ко многим
        public virtual List<Room> Rooms { get; set; } = new List<Room>();
    }
}