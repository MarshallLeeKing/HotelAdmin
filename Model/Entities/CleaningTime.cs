using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Model.Entities
{
    public class CleaningTime {

        public int Id { get; set; }
        public DateTime CleanTime { get; set; }
        public bool IsCleaned { get; set; }
        public string Commentary { get; set; }

        // связь один ко многим
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
    }
}
