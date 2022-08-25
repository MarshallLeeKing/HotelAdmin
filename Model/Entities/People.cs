
using System;
using System.Collections.Generic;

namespace HotelAdmin.Model.Entities
{
    // персональные данные
    public class People {

        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronim { get; set; }
        public string Passport { get; set; }

        public bool Male { get; set; }

        public DateTime BirthDate { get; set; }

        // связь с таблицей рабочих
        public virtual Employee Employee { get; set; }

        // связь с таблицей клиентов
        public virtual Client Client { get; set; }
    }
}
