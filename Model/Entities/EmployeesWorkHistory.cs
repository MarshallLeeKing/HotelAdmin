using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Model.Entities
{
    // таблица истории взаимодействия с рабочими
    public class EmployeesWorkHistory {
    
        public int Id { set; get; }

        // дата начала периода
        public DateTime DateStart { set; get; }

        // дата конца периода
        public DateTime DateEnd { get; set; }

        // количество выданных средств по факту за указанный срок
        public double Salary { set; get; }

        // связь с таблицей EmployeeStatus
        public int EmployeeStatusId { set; get; }
        public virtual EmployeeStatus EmployeeStatus { set; get; }

        // связь с таблицей Employee
        public int EmployeeId { set; get; }
        public virtual Employee Employee { set; get; }
    }
}
