
using System.Linq;
using System.Collections;

using HotelAdmin.Model;

namespace HotelAdmin.ViewModel {
    internal class HotelDbController : ViewModel {

        // база данных
        private HotelDb _db;

        public HotelDbController() {
            _db = new HotelDb();
        }

        public HotelDbController(HotelDb db) {
            _db = db;
        }

        // вывод таблицы People
        public IEnumerable GetTablePeoples() =>
            _db.Peoples.Select(p => new { p.Surname, p.Name, p.Patronim, p.Male, p.BirthDate, p.Passport }).ToList();

        // вывод таблицы Clients
        public IEnumerable GetTableClients() =>
            _db.Clients.Select(c => new { c.PeopleId, c.ArrivedCity.Name }).ToList();

        // вывод таблицы Employee
        public IEnumerable GetTableEmployee() =>
            _db.Employees.Select(e => new { e.PeopleId, e.BaseSalaryHr, e.DateIn, e.DateOut, e.EmployeeStatus.Status }).ToList();

        // вывод таблицы ClianingTime
        public IEnumerable GetTableCleaningTime() =>
            _db.CleaningTimes.Select(c => new { c.Employee.People.Name, c.Employee.People.Surname, c.Room.Floor, c.Room.Number, c.CleanTime }).ToList();

        // вывод таблицы TimeSheet
        public IEnumerable GetTableTimeSheet() =>
            _db.EmployeeTimesheets.Select(ts => new { ts.Employee.People.Name, ts.Employee.People.Surname, ts.DateStart, ts.DateEnd }).ToList();

        // вывод таблицы TimeEmployeesWorkHistory
        public IEnumerable GetTableEmployeesWorkHistory() =>
            _db.EmployeesWorkHistories.Select(e => new { e.Employee.People.Name, e.Employee.People.Surname, e.EmployeeStatus.Status, e.Salary, e.DateStart, e.DateEnd });
        
    }
}
