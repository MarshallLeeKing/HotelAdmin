using System;
using System.Collections.Generic;

namespace HotelAdmin.Model.Entities
{
    public class Employee {

        public int Id { get; set; }

        public double Salary { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime? DateOut { get; set; }
        public string Status { get; set; }

        // связь один к одному
        public int PeopleId { get; set; }
        public virtual People People { get; set; }

        // связь один ко многим
        public virtual List<CleaningTime> CleaningTimes { get; set; } = new List<CleaningTime>();
    }
}
