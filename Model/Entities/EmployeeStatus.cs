using System.Collections.Generic;

namespace HotelAdmin.Model.Entities
{
    // таблица статусов рабочих (работает, отпуск, уволен, больничный)
    public class EmployeeStatus {

        public int Id { get; set; }

        // непосредственно статус
        public string Status { get; set; }

        // связь с таблицей Employee
        public virtual List<Employee> Employees { get; set; } = new List<Employee>();

        // связь с таблицей EmployeesWorkHistory
        public virtual List<EmployeesWorkHistory> EmployeesWorkHistories { get; set; } = new List<EmployeesWorkHistory>();
    }
}
