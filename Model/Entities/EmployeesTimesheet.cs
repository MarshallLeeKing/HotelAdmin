using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Model.Entities
{
    // табель учета рабочего времени сотрудников
    public class EmployeesTimesheet {

        public int Id { get; set; }

        // дата начала рабочего дня (время)
        public DateTime DateStart { get; set; }

        // дата конца рабочего дня (время)
        public DateTime DateEnd { get; set; }

        // связь с таблицей Employee
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
