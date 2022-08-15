using System;
using System.Collections.Generic;

namespace HotelAdmin.Model.Entities
{
    // таблица с характеристиками комнат
    public class Room {
        
        public int Id { get; set; }
        
        // этаж
        public int Floor { get; set; }
        
        // номер комнаты
        public int Number { get; set; }
        
        // связь с таблицей PriceGroup
        public int PriceGroupId { get; set; }
        public virtual PriceGroup PriceGroup { get; set; }
        
        // связь с тиаблице CkeaningTime
        public virtual List<CleaningTime> CleaningTimes { get; set; } = new List<CleaningTime>();
    }
}
