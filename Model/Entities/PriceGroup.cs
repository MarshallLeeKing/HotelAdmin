using System;
using System.Collections.Generic;

namespace HotelAdmin.Model.Entities
{
    // группа цен на комнаты
    public class PriceGroup {

        public int Id { get; set; }

        // название группы 
        public string Name { get; set; }

        // цена
        public double Price { get; set; }

        // дата установки цены
        public DateTime DateStart { get; set; }

        // количество комнат
        public int RoomsCount { get; set; }

        // связь с таблицей комнат
        public virtual List<Room> Rooms { get; set; } = new List<Room>();
    }
}