using System;
using System.Collections.Generic;

namespace HotelAdmin.Model.Entities
{
    // сущность — рабочий (служащий)
    public class Employee {

        public int Id { get; set; }

        // зарплата в час (ставка)
        public double BaseSalaryHr { get; set; }

        // дата принятия на работу
        public DateTime DateIn { get; set; }

        // дата увольнения
        public DateTime? DateOut { get; set; }

        // связь с таблицей Peoples
        public int PeopleId { get; set; }
        public virtual People People { get; set; }

        // связь с таблицей CleaningTime
        public virtual List<CleaningTime> CleaningTimes { get; set; } = new List<CleaningTime>();

        // связь с таблицей EmployeeStatus
        public int EmployeeStatusId { get; set; }
        public virtual EmployeeStatus EmployeeStatus { get; set; }

        // связь с таблицей EmployeesTimesheet
        public virtual List<EmployeesTimesheet> EmployeesTimesheets { get; set; } = new List<EmployeesTimesheet>();

        // связь с таблицей EmployeeWorkHistory
        public virtual List<EmployeesWorkHistory> EmployeesWorkHistories { get; set; } = new List<EmployeesWorkHistory>();
    }
}
