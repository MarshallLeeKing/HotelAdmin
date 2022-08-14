using System;
using System.Collections.Generic;

namespace HotelAdmin.Model.Entities
{
    internal class PriceGroup {
    
        int Id { get; set; }
        string Name { get; set; }
        double Price { get; set; }
        DateTime DateStart { get; set; }

        // связь один ко многим
        List<Room> Rooms { get; set; } = new List<Room>();
    }
}