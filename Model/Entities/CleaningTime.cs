using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Model.Entities
{
    // расписание уборок
    public class CleaningTime {

        public int Id { get; set; }
        
        // дата и время уборки
        public DateTime CleanTime { get; set; }
        
        // выполнена уборка или нет
        public bool IsCleaned { get; set; }
        
        // коментарий (почему не выполнена)
        public string Commentary { get; set; }

        // связь с таблицей EmployeeId
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        // связь с таблицей RoomId
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
    }
}
