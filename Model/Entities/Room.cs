using System;
using System.Collections.Generic;

namespace HotelAdmin.Model.Entities
{
    public class Room {
        
        public int Id { get; set; }
        public int Floor { get; set; }
        public int Number { get; set; }
        public int RoomsCount { get; set; }

        // связь один ко многим
        public int PeiceGroupId { get; set; }
        public virtual PriceGroup PriceGroup { get; set; }
        
        // связь многие ко многим
        public virtual List<CleaningTime> CleaningTimes { get; set; } = new List<CleaningTime>();
        public virtual List<Room> Rooms { get; set; } = new List<Room>();
    }
}
