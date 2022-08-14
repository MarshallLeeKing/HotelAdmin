using System;
using System.Collections.Generic;

namespace HotelAdmin.Model.Entities
{
    internal class Employee {
    
        int Id { get; set; }

        double Salary { get; set; }
        DateTime DateIn { get; set; }
        DateTime? DateOut { get; set; }
        string Status { get; set; }

        // связь один к одному
        int PeopleId { get; set; }
        People People { get; set; }

        // связь один ко многим
        List<CleaningTime> CleaningTimes { get; set; } = new List<CleaningTime>();
    }
}
