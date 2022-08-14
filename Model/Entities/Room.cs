using System;
using System.Collections.Generic;

namespace HotelAdmin.Model.Entities
{
    internal class Room {
        
        int Id { get; set; }
        int Floor { get; set; }
        int Number { get; set; }
        int RoomsCount { get; set; }

        // связь один ко многим
        int PeiceGroupId { get; set; }
        PriceGroup PriceGroup { get; set; }
        
        // связь многие ко многим
        List<CleaningTime> CleaningTimes { get; set; } = new List<CleaningTime>();
        List<Room> Rooms { get; set; } = new List<Room>();
    }
}
