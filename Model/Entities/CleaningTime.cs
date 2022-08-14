using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Model.Entities
{
    internal class CleaningTime {

        int Id { get; set; }
        DateTime CleanTime { get; set; }
        bool IsCleaned { get; set; }
        string Commentary { get; set; }

        // связь один ко многим
        int EmployeeId { get; set; }
        Employee Employee { get; set; }

        int RoomId { get; set; }
        Room Room { get; set; }
    }
}
