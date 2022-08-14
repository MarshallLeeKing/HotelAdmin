
using System;
using System.Collections.Generic;

namespace HotelAdmin.Model.Entities
{
    internal class People {
        int Id { get; set; }

        string Name { get; set; }
        string Surname { get; set; }
        string Patronim { get; set; }
        string Passport { get; set; }
        
        bool Male { get; set; }
        
        DateTime BirthDate { get; set; }

        // связь один к одному
        Employee Employee { get; set; }
        Client Client { get; set; }
    }
}
