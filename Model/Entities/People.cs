
using System;
using System.Collections.Generic;

namespace HotelAdmin.Model.Entities
{
    public class People {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronim { get; set; }
        public string Passport { get; set; }

        public bool Male { get; set; }

        public DateTime BirthDate { get; set; }

        // связь один к одному
        public virtual Employee Employee { get; set; }
        public virtual Client Client { get; set; }
    }
}
