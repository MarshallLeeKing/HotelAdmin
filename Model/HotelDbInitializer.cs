using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

using HotelAdmin.Model.Entities;

namespace HotelAdmin.Model
{
    internal class HotelDbInitializer : DropCreateDatabaseIfModelChanges<HotelDb> {

        private static int _i = 1;

        // переопределяем метод для инициализации БД при первом обращении к ней
        protected override void Seed(HotelDb context) {

            InitializePeoples(context);
            InitializeEmployeeStatus(context);
            InitializeEmployeesTimesheet(context);
            InitializeEmployees(context);
            InitializeEmployeesworkHistory(context);
            InitializePriceGroup(context);
            InitializeRoom(context);
            InitializeCleaningTime(context);
            InitilizeClient(context);
            InitilizeCity(context);
            InitializeOrderStatus(context);
            InitializeOrder(context);
            InitializeRoommate(context);

            context.SaveChanges();

        }

        // заполнение таблицы Peoples
        private void InitializePeoples(HotelDb context) {
            context.Peoples.Add(new People { Id = 1, Name = "Иван", Patronim = "Иванович", Surname = "Иванов", BirthDate = new DateTime(1970, 4, 24), Male = true, Passport = "ВТ 134421" });
            context.Peoples.Add(new People { Id = 2, Name = "Виктор", Patronim = "Константинович", Surname = "Цой", BirthDate = new DateTime(1968, 7, 12), Male = true, Passport = "ВА 154835" });
            context.Peoples.Add(new People { Id = 3, Name = "Ольга", Patronim = "Денисовна", Surname = "Акименко", BirthDate = new DateTime(1987, 1, 19), Male = false, Passport = "ВА 554289" });
            context.Peoples.Add(new People { Id = 4, Name = "Матильда", Patronim = "Геогиевна", Surname = "Позднякова", BirthDate = new DateTime(1997, 8, 1), Male = false, Passport = "ДА 135482" });
            context.Peoples.Add(new People { Id = 5, Name = "Лолита", Patronim = "Павловна", Surname = "Вуйчич", BirthDate = new DateTime(1980, 5, 20), Male = false, Passport = "ДД 218745" });
            context.Peoples.Add(new People { Id = 6, Name = "Владимир", Patronim = "Олегович", Surname = "Яровой", BirthDate = new DateTime(1979, 3, 11), Male = true, Passport = "ВУ 552182" });
            context.Peoples.Add(new People { Id = 7, Name = "Анатолий", Patronim = "Викторович", Surname = "Резник", BirthDate = new DateTime(1985, 8, 25), Male = true, Passport = "ВТ 656842" });
            context.Peoples.Add(new People { Id = 8, Name = "Марина", Patronim = "Олеговна", Surname = "Петропа", BirthDate = new DateTime(1999, 7, 9), Male = false, Passport = "ВТ 552486" });
            context.Peoples.Add(new People { Id = 9, Name = "Дмитрий", Patronim = "Максимович", Surname = "Гагулин", BirthDate = new DateTime(2001, 1, 10), Male = true, Passport = "ВТ 112548" });
            context.Peoples.Add(new People { Id = 10, Name = "Карина", Patronim = "Альбертовна", Surname = "Тигенская", BirthDate = new DateTime(1966, 9, 20), Male = false, Passport = "ВЛ 354984" });
            context.Peoples.Add(new People { Id = 11, Name = "Лариса", Patronim = "Вячеславовна", Surname = "Салова", BirthDate = new DateTime(1989, 12, 21), Male = false, Passport = "ВУ 135490" });
            context.Peoples.Add(new People { Id = 12, Name = "Павел", Patronim = "Павлович", Surname = "Салов", BirthDate = new DateTime(1985, 11, 17), Male = true, Passport = "ВЕ 210548" });
            context.Peoples.Add(new People { Id = 13, Name = "Юрий", Patronim = "Инокентиевич", Surname = "Семенов", BirthDate = new DateTime(1990, 12, 18), Male = true, Passport = "ВТ 221659" });
            context.Peoples.Add(new People { Id = 14, Name = "Милана", Patronim = "Тихоновна", Surname = "Салова", BirthDate = new DateTime(2015, 10, 19), Male = false, Passport = "ВТ 336591" });
            context.Peoples.Add(new People { Id = 15, Name = "Ксения", Patronim = "Николаевна", Surname = "Метрич", BirthDate = new DateTime(1988, 9, 21), Male = false, Passport = "ВТ 369015" });
            context.Peoples.Add(new People { Id = 16, Name = "Олег", Patronim = "Романович", Surname = "Липа", BirthDate = new DateTime(1971, 8, 17), Male = true, Passport = "ВТ 752016" });
            context.Peoples.Add(new People { Id = 17, Name = "Константин", Patronim = "Олегович", Surname = "Дудин", BirthDate = new DateTime(1980, 6, 11), Male = true, Passport = "ВТ 126509" });
            context.Peoples.Add(new People { Id = 18, Name = "Максим", Patronim = "Петрович", Surname = "Рувинский", BirthDate = new DateTime(1998, 7, 10), Male = true, Passport = "ВТ 898540" });
            context.Peoples.Add(new People { Id = 19, Name = "Людмила", Patronim = "Романовна", Surname = "Дудина", BirthDate = new DateTime(1981, 8, 8), Male = false, Passport = "ВТ 698422" });
            context.Peoples.Add(new People { Id = 20, Name = "Тамара", Patronim = "Тихоновна", Surname = "Рувинская", BirthDate = new DateTime(1970, 3, 2), Male = false, Passport = "ВТ 885172" });
        }

        // заполнение таблицы EmployeeStatus
        private void InitializeEmployeeStatus(HotelDb context) {
            context.EmployeeStatuses.Add(new EmployeeStatus { Id = 1, Status = "Работает" });
            context.EmployeeStatuses.Add(new EmployeeStatus { Id = 2, Status = "В отпуске" });
            context.EmployeeStatuses.Add(new EmployeeStatus { Id = 3, Status = "На больничном" });
            context.EmployeeStatuses.Add(new EmployeeStatus { Id = 4, Status = "Уволен" });
        }

        // заполнение таблицы EmployeesTimesheet
        private void InitializeEmployeesTimesheet(HotelDb context) {
            // записи первого служащего за май 2022
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 5, 1, 8, 0, 0), DateEnd = new DateTime(2022, 5, 1, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 5, 2, 8, 0, 0), DateEnd = new DateTime(2022, 5, 2, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 5, 3, 8, 0, 0), DateEnd = new DateTime(2022, 5, 3, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 5, 6, 8, 0, 0), DateEnd = new DateTime(2022, 5, 6, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 5, 7, 8, 0, 0), DateEnd = new DateTime(2022, 5, 7, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 5, 8, 8, 0, 0), DateEnd = new DateTime(2022, 5, 8, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 5, 9, 8, 0, 0), DateEnd = new DateTime(2022, 5, 9, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 5, 10, 8, 0, 0), DateEnd = new DateTime(2022, 5, 10, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 5, 12, 8, 0, 0), DateEnd = new DateTime(2022, 5, 12, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 5, 13, 8, 0, 0), DateEnd = new DateTime(2022, 5, 13, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 5, 14, 8, 0, 0), DateEnd = new DateTime(2022, 5, 14, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 5, 15, 8, 0, 0), DateEnd = new DateTime(2022, 5, 15, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 5, 19, 8, 0, 0), DateEnd = new DateTime(2022, 5, 19, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 5, 20, 8, 0, 0), DateEnd = new DateTime(2022, 5, 20, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 5, 21, 8, 0, 0), DateEnd = new DateTime(2022, 5, 21, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 5, 22, 8, 0, 0), DateEnd = new DateTime(2022, 5, 22, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 5, 24, 8, 0, 0), DateEnd = new DateTime(2022, 5, 24, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 5, 25, 8, 0, 0), DateEnd = new DateTime(2022, 5, 25, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 5, 26, 8, 0, 0), DateEnd = new DateTime(2022, 5, 26, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 5, 27, 8, 0, 0), DateEnd = new DateTime(2022, 5, 27, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 5, 30, 8, 0, 0), DateEnd = new DateTime(2022, 5, 30, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 5, 31, 8, 0, 0), DateEnd = new DateTime(2022, 5, 31, 18, 0, 0) });
            // записи второго служащего за май 2022
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 5, 1, 8, 0, 0), DateEnd = new DateTime(2022, 5, 1, 19, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 5, 2, 8, 0, 0), DateEnd = new DateTime(2022, 5, 2, 19, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 5, 3, 8, 0, 0), DateEnd = new DateTime(2022, 5, 3, 19, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 5, 4, 8, 0, 0), DateEnd = new DateTime(2022, 5, 4, 19, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 5, 5, 8, 0, 0), DateEnd = new DateTime(2022, 5, 5, 19, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 5, 8, 8, 0, 0), DateEnd = new DateTime(2022, 5, 8, 19, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 5, 9, 8, 0, 0), DateEnd = new DateTime(2022, 5, 9, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 5, 10, 8, 0, 0), DateEnd = new DateTime(2022, 5, 10, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 5, 12, 8, 0, 0), DateEnd = new DateTime(2022, 5, 12, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 5, 13, 8, 0, 0), DateEnd = new DateTime(2022, 5, 13, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 5, 14, 8, 0, 0), DateEnd = new DateTime(2022, 5, 14, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 5, 15, 8, 0, 0), DateEnd = new DateTime(2022, 5, 15, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 5, 19, 8, 0, 0), DateEnd = new DateTime(2022, 5, 19, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 5, 20, 8, 0, 0), DateEnd = new DateTime(2022, 5, 20, 15, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 5, 21, 8, 0, 0), DateEnd = new DateTime(2022, 5, 21, 15, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 5, 22, 8, 0, 0), DateEnd = new DateTime(2022, 5, 22, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 5, 24, 8, 0, 0), DateEnd = new DateTime(2022, 5, 24, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 5, 25, 8, 0, 0), DateEnd = new DateTime(2022, 5, 25, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 5, 28, 8, 0, 0), DateEnd = new DateTime(2022, 5, 28, 19, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 5, 29, 8, 0, 0), DateEnd = new DateTime(2022, 5, 29, 19, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 5, 30, 8, 0, 0), DateEnd = new DateTime(2022, 5, 30, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 5, 31, 8, 0, 0), DateEnd = new DateTime(2022, 5, 31, 18, 0, 0) });
            // записи третьего служащего за май 2022
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 3, DateStart = new DateTime(2022, 5, 1, 7, 0, 0), DateEnd = new DateTime(2022, 5, 1, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 3, DateStart = new DateTime(2022, 5, 2, 7, 0, 0), DateEnd = new DateTime(2022, 5, 2, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 3, DateStart = new DateTime(2022, 5, 3, 7, 0, 0), DateEnd = new DateTime(2022, 5, 3, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 3, DateStart = new DateTime(2022, 5, 4, 7, 0, 0), DateEnd = new DateTime(2022, 5, 4, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 3, DateStart = new DateTime(2022, 5, 5, 7, 0, 0), DateEnd = new DateTime(2022, 5, 5, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 3, DateStart = new DateTime(2022, 5, 12, 7, 0, 0), DateEnd = new DateTime(2022, 5, 12, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 3, DateStart = new DateTime(2022, 5, 13, 7, 0, 0), DateEnd = new DateTime(2022, 5, 13, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 3, DateStart = new DateTime(2022, 5, 14, 7, 0, 0), DateEnd = new DateTime(2022, 5, 14, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 3, DateStart = new DateTime(2022, 5, 15, 7, 0, 0), DateEnd = new DateTime(2022, 5, 15, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 3, DateStart = new DateTime(2022, 5, 19, 7, 0, 0), DateEnd = new DateTime(2022, 5, 19, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 3, DateStart = new DateTime(2022, 5, 20, 7, 0, 0), DateEnd = new DateTime(2022, 5, 20, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 3, DateStart = new DateTime(2022, 5, 21, 7, 0, 0), DateEnd = new DateTime(2022, 5, 21, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 3, DateStart = new DateTime(2022, 5, 26, 7, 0, 0), DateEnd = new DateTime(2022, 5, 26, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 3, DateStart = new DateTime(2022, 5, 27, 7, 0, 0), DateEnd = new DateTime(2022, 5, 27, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 3, DateStart = new DateTime(2022, 5, 30, 7, 0, 0), DateEnd = new DateTime(2022, 5, 30, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 3, DateStart = new DateTime(2022, 5, 31, 7, 0, 0), DateEnd = new DateTime(2022, 5, 31, 20, 0, 0) });
            // записи четвертого служащего за май 2022              

            // записи пятого служащего за май 2022                  
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 5, 1, 9, 0, 0), DateEnd = new DateTime(2022, 5, 1, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 5, 2, 9, 0, 0), DateEnd = new DateTime(2022, 5, 2, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 5, 3, 9, 0, 0), DateEnd = new DateTime(2022, 5, 3, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 5, 4, 9, 0, 0), DateEnd = new DateTime(2022, 5, 4, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 5, 5, 9, 0, 0), DateEnd = new DateTime(2022, 5, 5, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 5, 8, 9, 0, 0), DateEnd = new DateTime(2022, 5, 8, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 5, 9, 9, 0, 0), DateEnd = new DateTime(2022, 5, 9, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 5, 10, 9, 0, 0), DateEnd = new DateTime(2022, 5, 10, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 5, 12, 9, 0, 0), DateEnd = new DateTime(2022, 5, 12, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 5, 13, 9, 0, 0), DateEnd = new DateTime(2022, 5, 13, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 5, 14, 9, 0, 0), DateEnd = new DateTime(2022, 5, 14, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 5, 15, 9, 0, 0), DateEnd = new DateTime(2022, 5, 15, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 5, 19, 9, 0, 0), DateEnd = new DateTime(2022, 5, 19, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 5, 20, 9, 0, 0), DateEnd = new DateTime(2022, 5, 20, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 5, 21, 8, 0, 0), DateEnd = new DateTime(2022, 5, 21, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 5, 22, 9, 0, 0), DateEnd = new DateTime(2022, 5, 22, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 5, 24, 9, 0, 0), DateEnd = new DateTime(2022, 5, 24, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 5, 25, 9, 0, 0), DateEnd = new DateTime(2022, 5, 25, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 5, 26, 9, 0, 0), DateEnd = new DateTime(2022, 5, 26, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 5, 27, 9, 0, 0), DateEnd = new DateTime(2022, 5, 27, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 5, 30, 9, 0, 0), DateEnd = new DateTime(2022, 5, 30, 18, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 5, 31, 9, 0, 0), DateEnd = new DateTime(2022, 5, 31, 18, 0, 0) });
            // записи шестого служащего за май 2022
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 1, 9, 0, 0), DateEnd = new DateTime(2022, 5, 1, 19, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 2, 9, 0, 0), DateEnd = new DateTime(2022, 5, 2, 19, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 3, 9, 0, 0), DateEnd = new DateTime(2022, 5, 3, 19, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 4, 9, 0, 0), DateEnd = new DateTime(2022, 5, 4, 19, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 5, 9, 0, 0), DateEnd = new DateTime(2022, 5, 5, 19, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 8, 9, 0, 0), DateEnd = new DateTime(2022, 5, 8, 19, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 9, 9, 0, 0), DateEnd = new DateTime(2022, 5, 9, 19, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 10, 9, 0, 0), DateEnd = new DateTime(2022, 5, 10, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 12, 9, 0, 0), DateEnd = new DateTime(2022, 5, 12, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 13, 9, 0, 0), DateEnd = new DateTime(2022, 5, 13, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 14, 9, 0, 0), DateEnd = new DateTime(2022, 5, 14, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 15, 9, 0, 0), DateEnd = new DateTime(2022, 5, 15, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 19, 9, 0, 0), DateEnd = new DateTime(2022, 5, 19, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 20, 9, 0, 0), DateEnd = new DateTime(2022, 5, 20, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 21, 9, 0, 0), DateEnd = new DateTime(2022, 5, 21, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 22, 9, 0, 0), DateEnd = new DateTime(2022, 5, 22, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 24, 9, 0, 0), DateEnd = new DateTime(2022, 5, 24, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 25, 9, 0, 0), DateEnd = new DateTime(2022, 5, 25, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 26, 9, 0, 0), DateEnd = new DateTime(2022, 5, 26, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 27, 9, 0, 0), DateEnd = new DateTime(2022, 5, 27, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 30, 9, 0, 0), DateEnd = new DateTime(2022, 5, 30, 20, 0, 0) });
            context.EmployeeTimesheets.Add(new EmployeesTimesheet { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 31, 7, 0, 0), DateEnd = new DateTime(2022, 5, 31, 20, 0, 0) });
            _i = 1;
        }

        // заполнение таблицы Employees
        private void InitializeEmployees(HotelDb context) {
            context.Employees.Add(new Employee { Id = 1, PeopleId = 1, BaseSalaryHr = 160d, EmployeeStatusId = 1, DateIn = new DateTime(2020, 2, 20), DateOut = null });
            context.Employees.Add(new Employee { Id = 2, PeopleId = 5, BaseSalaryHr = 145d, EmployeeStatusId = 1, DateIn = new DateTime(2021, 4, 15), DateOut = null });
            context.Employees.Add(new Employee { Id = 3, PeopleId = 7, BaseSalaryHr = 115d, EmployeeStatusId = 1, DateIn = new DateTime(2022, 1, 10), DateOut = null });
            context.Employees.Add(new Employee { Id = 4, PeopleId = 6, BaseSalaryHr = 115d, EmployeeStatusId = 1, DateIn = new DateTime(2022, 2, 1), DateOut = null });
            context.Employees.Add(new Employee { Id = 5, PeopleId = 8, BaseSalaryHr = 115d, EmployeeStatusId = 4, DateIn = new DateTime(2022, 2, 1), DateOut = new DateTime(2022, 4, 30) });
            context.Employees.Add(new Employee { Id = 6, PeopleId = 9, BaseSalaryHr = 115d, EmployeeStatusId = 1, DateIn = new DateTime(2022, 2, 1), DateOut = null });
        }

        // заполнение таблицы EmployeeWorkHistory
        private void InitializeEmployeesworkHistory(HotelDb context) {
            // данные по первому сотруднику
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 1, 1), DateEnd = new DateTime(2022, 1, 31), EmployeeStatusId = 1, Salary = 22000d });
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 2, 1), DateEnd = new DateTime(2022, 2, 28), EmployeeStatusId = 1, Salary = 22000d });
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 3, 1), DateEnd = new DateTime(2022, 3, 31), EmployeeStatusId = 1, Salary = 24000d });
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 4, 1), DateEnd = new DateTime(2022, 4, 30), EmployeeStatusId = 1, Salary = 24000d });
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 1, DateStart = new DateTime(2022, 5, 1), DateEnd = new DateTime(2022, 5, 31), EmployeeStatusId = 1, Salary = 27000d });
            // данные по второму сотруднику
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 1, 1), DateEnd = new DateTime(2022, 1, 31), EmployeeStatusId = 1, Salary = 22000d });
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 2, 1), DateEnd = new DateTime(2022, 2, 28), EmployeeStatusId = 1, Salary = 22000d });
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 3, 1), DateEnd = new DateTime(2022, 3, 31), EmployeeStatusId = 1, Salary = 24000d });
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 4, 1), DateEnd = new DateTime(2022, 4, 30), EmployeeStatusId = 1, Salary = 24000d });
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 2, DateStart = new DateTime(2022, 5, 1), DateEnd = new DateTime(2022, 5, 31), EmployeeStatusId = 1, Salary = 27000d });
            // данные по третьему сотруднику
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 3, DateStart = new DateTime(2022, 1, 10), DateEnd = new DateTime(2022, 1, 31), EmployeeStatusId = 1, Salary = 12000d });
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 3, DateStart = new DateTime(2022, 2, 1), DateEnd = new DateTime(2022, 2, 28), EmployeeStatusId = 1, Salary = 22000d });
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 3, DateStart = new DateTime(2022, 3, 1), DateEnd = new DateTime(2022, 3, 31), EmployeeStatusId = 1, Salary = 24000d });
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 3, DateStart = new DateTime(2022, 4, 1), DateEnd = new DateTime(2022, 4, 30), EmployeeStatusId = 1, Salary = 24000d });
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 3, DateStart = new DateTime(2022, 5, 1), DateEnd = new DateTime(2022, 5, 31), EmployeeStatusId = 1, Salary = 27000d });
            // данные по четвертому сотруднику            
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 4, DateStart = new DateTime(2022, 2, 1), DateEnd = new DateTime(2022, 2, 28), EmployeeStatusId = 1, Salary = 18000d });
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 4, DateStart = new DateTime(2022, 3, 1), DateEnd = new DateTime(2022, 3, 31), EmployeeStatusId = 1, Salary = 19000d });
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 4, DateStart = new DateTime(2022, 4, 1), DateEnd = new DateTime(2022, 4, 30), EmployeeStatusId = 1, Salary = 20000d });
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 4, DateStart = new DateTime(2022, 5, 1), DateEnd = new DateTime(2022, 5, 31), EmployeeStatusId = 1, Salary = 20000d });
            // данные по пятому сотруднику
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 2, 1), DateEnd = new DateTime(2022, 2, 28), EmployeeStatusId = 1, Salary = 19000d });
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 3, 1), DateEnd = new DateTime(2022, 3, 31), EmployeeStatusId = 1, Salary = 18000d });
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 5, DateStart = new DateTime(2022, 4, 1), DateEnd = new DateTime(2022, 4, 30), EmployeeStatusId = 1, Salary = 20000d });
            // данные по шестому сотруднику
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 2, 1), DateEnd = new DateTime(2022, 2, 28), EmployeeStatusId = 1, Salary = 19000d });
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 3, 1), DateEnd = new DateTime(2022, 3, 31), EmployeeStatusId = 1, Salary = 19000d });
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 4, 1), DateEnd = new DateTime(2022, 4, 30), EmployeeStatusId = 1, Salary = 20000d });
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 1), DateEnd = new DateTime(2022, 5, 22), EmployeeStatusId = 2, Salary = 8000d });
            context.EmployeesWorkHistories.Add(new EmployeesWorkHistory { Id = _i++, EmployeeId = 6, DateStart = new DateTime(2022, 5, 23), DateEnd = new DateTime(2022, 5, 31), EmployeeStatusId = 1, Salary = 8000d });
            _i = 1;
        }

        // заполнение таблицы PriceGroup
        private void InitializePriceGroup(HotelDb context) {
            context.PriceGroups.Add(new PriceGroup { Id = 1, Name = "Эконом", RoomsCount = 1, Price = 1500, DateStart = new DateTime(2000, 1, 1) });
            context.PriceGroups.Add(new PriceGroup { Id = 2, Name = "Стандарт", RoomsCount = 2, Price = 2200, DateStart = new DateTime(2000, 1, 1) });
            context.PriceGroups.Add(new PriceGroup { Id = 3, Name = "Стандарт", RoomsCount = 3, Price = 2800, DateStart = new DateTime(2000, 1, 1) });
            context.PriceGroups.Add(new PriceGroup { Id = 4, Name = "Люкс", RoomsCount = 1, Price = 2200, DateStart = new DateTime(2000, 1, 1) });
            context.PriceGroups.Add(new PriceGroup { Id = 5, Name = "Люкс", RoomsCount = 2, Price = 3000, DateStart = new DateTime(2000, 1, 1) });
            context.PriceGroups.Add(new PriceGroup { Id = 6, Name = "Люкс", RoomsCount = 3, Price = 4300, DateStart = new DateTime(2000, 1, 1) });
        }

        // заполнение таблицы Room
        private void InitializeRoom(HotelDb context) {
            context.Rooms.Add(new Room { Id = 1, Floor = 1, Number = 1, PriceGroupId = 1 });
            context.Rooms.Add(new Room { Id = 2, Floor = 1, Number = 2, PriceGroupId = 1 });
            context.Rooms.Add(new Room { Id = 3, Floor = 1, Number = 3, PriceGroupId = 1 });
            context.Rooms.Add(new Room { Id = 4, Floor = 1, Number = 4, PriceGroupId = 1 });
            context.Rooms.Add(new Room { Id = 5, Floor = 1, Number = 5, PriceGroupId = 3 });
            context.Rooms.Add(new Room { Id = 6, Floor = 1, Number = 6, PriceGroupId = 2 });
            context.Rooms.Add(new Room { Id = 7, Floor = 1, Number = 7, PriceGroupId = 2 });
            context.Rooms.Add(new Room { Id = 8, Floor = 1, Number = 8, PriceGroupId = 3 });
            context.Rooms.Add(new Room { Id = 9, Floor = 1, Number = 9, PriceGroupId = 2 });
            context.Rooms.Add(new Room { Id = 10, Floor = 2, Number = 10, PriceGroupId = 2 });
            context.Rooms.Add(new Room { Id = 11, Floor = 2, Number = 11, PriceGroupId = 3 });
            context.Rooms.Add(new Room { Id = 12, Floor = 2, Number = 12, PriceGroupId = 3 });
            context.Rooms.Add(new Room { Id = 13, Floor = 2, Number = 13, PriceGroupId = 3 });
            context.Rooms.Add(new Room { Id = 14, Floor = 2, Number = 14, PriceGroupId = 2 });
            context.Rooms.Add(new Room { Id = 15, Floor = 2, Number = 15, PriceGroupId = 2 });
            context.Rooms.Add(new Room { Id = 16, Floor = 2, Number = 16, PriceGroupId = 2 });
            context.Rooms.Add(new Room { Id = 17, Floor = 3, Number = 17, PriceGroupId = 4 });
            context.Rooms.Add(new Room { Id = 18, Floor = 3, Number = 18, PriceGroupId = 4 });
            context.Rooms.Add(new Room { Id = 19, Floor = 3, Number = 19, PriceGroupId = 5 });
            context.Rooms.Add(new Room { Id = 20, Floor = 3, Number = 20, PriceGroupId = 5 });
            context.Rooms.Add(new Room { Id = 21, Floor = 3, Number = 21, PriceGroupId = 6 });
        }

        // заполнение таблицы CleaningTime
        private void InitializeCleaningTime(HotelDb context) {
            // данные для первого служащего
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 1, CleanTime = new DateTime(2022, 5, 1, 9, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 2, CleanTime = new DateTime(2022, 5, 1, 10, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 3, CleanTime = new DateTime(2022, 5, 1, 11, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 4, CleanTime = new DateTime(2022, 5, 2, 9, 0, 0), IsCleaned = false, Commentary = "Жильцы не пустили в номер" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 5, CleanTime = new DateTime(2022, 5, 2, 12, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 6, CleanTime = new DateTime(2022, 5, 2, 13, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 7, CleanTime = new DateTime(2022, 5, 3, 12, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 8, CleanTime = new DateTime(2022, 5, 3, 14, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 9, CleanTime = new DateTime(2022, 5, 3, 9, 0, 0), IsCleaned = false, Commentary = "Жильцы не пустили в номер" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 11, CleanTime = new DateTime(2022, 5, 6, 8, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 10, CleanTime = new DateTime(2022, 5, 6, 7, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 12, CleanTime = new DateTime(2022, 5, 6, 10, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 14, CleanTime = new DateTime(2022, 5, 7, 11, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 15, CleanTime = new DateTime(2022, 5, 7, 12, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 16, CleanTime = new DateTime(2022, 5, 8, 10, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 1, CleanTime = new DateTime(2022, 5, 8, 9, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 2, CleanTime = new DateTime(2022, 5, 8, 12, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 3, CleanTime = new DateTime(2022, 5, 10, 8, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 4, CleanTime = new DateTime(2022, 5, 10, 9, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 5, CleanTime = new DateTime(2022, 5, 10, 10, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 2, CleanTime = new DateTime(2022, 5, 10, 11, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 4, CleanTime = new DateTime(2022, 5, 12, 9, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 1, CleanTime = new DateTime(2022, 5, 12, 11, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 8, CleanTime = new DateTime(2022, 5, 12, 13, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 7, CleanTime = new DateTime(2022, 5, 12, 15, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 6, CleanTime = new DateTime(2022, 5, 13, 15, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 11, CleanTime = new DateTime(2022, 5, 13, 16, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 12, CleanTime = new DateTime(2022, 5, 13, 17, 0, 0), IsCleaned = true, Commentary = "Перенесли уборку по просьбе клиента" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 13, CleanTime = new DateTime(2022, 5, 13, 11, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 14, CleanTime = new DateTime(2022, 5, 20, 8, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 21, CleanTime = new DateTime(2022, 5, 21, 9, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 20, CleanTime = new DateTime(2022, 5, 21, 10, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 19, CleanTime = new DateTime(2022, 5, 22, 11, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 18, CleanTime = new DateTime(2022, 5, 24, 12, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 1, CleanTime = new DateTime(2022, 5, 24, 11, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 2, CleanTime = new DateTime(2022, 5, 25, 10, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 3, CleanTime = new DateTime(2022, 5, 25, 9, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 4, CleanTime = new DateTime(2022, 5, 25, 7, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 5, CleanTime = new DateTime(2022, 5, 25, 11, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 6, CleanTime = new DateTime(2022, 5, 26, 12, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 7, CleanTime = new DateTime(2022, 5, 26, 13, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 8, CleanTime = new DateTime(2022, 5, 26, 14, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 9, CleanTime = new DateTime(2022, 5, 27, 10, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 10, CleanTime = new DateTime(2022, 5, 30, 10, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 1, RoomId = 16, CleanTime = new DateTime(2022, 5, 31, 10, 0, 0), IsCleaned = true, Commentary = "" });
            // данные для второго служащего
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 10, CleanTime = new DateTime(2022, 5, 1, 9, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 11, CleanTime = new DateTime(2022, 5, 1, 10, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 12, CleanTime = new DateTime(2022, 5, 1, 11, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 14, CleanTime = new DateTime(2022, 5, 2, 9, 0, 0), IsCleaned = false, Commentary = "Жильцы не пустили в номер" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 15, CleanTime = new DateTime(2022, 5, 2, 12, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 16, CleanTime = new DateTime(2022, 5, 2, 13, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 17, CleanTime = new DateTime(2022, 5, 3, 12, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 18, CleanTime = new DateTime(2022, 5, 3, 14, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 19, CleanTime = new DateTime(2022, 5, 3, 9, 0, 0), IsCleaned = false, Commentary = "Жильцы не пустили в номер" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 20, CleanTime = new DateTime(2022, 5, 6, 8, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 21, CleanTime = new DateTime(2022, 5, 6, 7, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 3, CleanTime = new DateTime(2022, 5, 4, 10, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 1, CleanTime = new DateTime(2022, 5, 5, 11, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 2, CleanTime = new DateTime(2022, 5, 5, 12, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 3, CleanTime = new DateTime(2022, 5, 8, 10, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 4, CleanTime = new DateTime(2022, 5, 8, 9, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 5, CleanTime = new DateTime(2022, 5, 8, 12, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 6, CleanTime = new DateTime(2022, 5, 10, 8, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 7, CleanTime = new DateTime(2022, 5, 10, 9, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 8, CleanTime = new DateTime(2022, 5, 10, 10, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 9, CleanTime = new DateTime(2022, 5, 10, 11, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 10, CleanTime = new DateTime(2022, 5, 12, 9, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 11, CleanTime = new DateTime(2022, 5, 12, 11, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 18, CleanTime = new DateTime(2022, 5, 12, 13, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 17, CleanTime = new DateTime(2022, 5, 12, 15, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 16, CleanTime = new DateTime(2022, 5, 13, 15, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 12, CleanTime = new DateTime(2022, 5, 13, 16, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 14, CleanTime = new DateTime(2022, 5, 13, 17, 0, 0), IsCleaned = true, Commentary = "Перенесли уборку по просьбе клиента" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 9, CleanTime = new DateTime(2022, 5, 13, 11, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 8, CleanTime = new DateTime(2022, 5, 20, 8, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 7, CleanTime = new DateTime(2022, 5, 21, 9, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 6, CleanTime = new DateTime(2022, 5, 21, 10, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 4, CleanTime = new DateTime(2022, 5, 22, 11, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 5, CleanTime = new DateTime(2022, 5, 24, 12, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 8, CleanTime = new DateTime(2022, 5, 24, 11, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 9, CleanTime = new DateTime(2022, 5, 25, 10, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 10, CleanTime = new DateTime(2022, 5, 25, 9, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 11, CleanTime = new DateTime(2022, 5, 25, 7, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 12, CleanTime = new DateTime(2022, 5, 25, 11, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 7, CleanTime = new DateTime(2022, 5, 28, 12, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 9, CleanTime = new DateTime(2022, 5, 28, 13, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 10, CleanTime = new DateTime(2022, 5, 29, 14, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 11, CleanTime = new DateTime(2022, 5, 29, 10, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 12, CleanTime = new DateTime(2022, 5, 30, 10, 0, 0), IsCleaned = true, Commentary = "" });
            context.CleaningTimes.Add(new CleaningTime { Id = _i++, EmployeeId = 2, RoomId = 13, CleanTime = new DateTime(2022, 5, 31, 10, 0, 0), IsCleaned = true, Commentary = "" });
            _i = 1;
        }

        // заполнение таблицы Client
        private void InitilizeClient(HotelDb context) {
            context.Clients.Add(new Client { Id = 1, PeopleId = 2, ArrivedCityId = 1 });
            context.Clients.Add(new Client { Id = 2, PeopleId = 3, ArrivedCityId = 2 });
            context.Clients.Add(new Client { Id = 3, PeopleId = 4, ArrivedCityId = 3 });
            context.Clients.Add(new Client { Id = 4, PeopleId = 10, ArrivedCityId = 4 });
            context.Clients.Add(new Client { Id = 5, PeopleId = 11, ArrivedCityId = 5 });
            context.Clients.Add(new Client { Id = 6, PeopleId = 12, ArrivedCityId = 5 });
            context.Clients.Add(new Client { Id = 7, PeopleId = 13, ArrivedCityId = 6 });
            context.Clients.Add(new Client { Id = 8, PeopleId = 14, ArrivedCityId = 5 });
            context.Clients.Add(new Client { Id = 9, PeopleId = 15, ArrivedCityId = 7 });
            context.Clients.Add(new Client { Id = 10, PeopleId = 16, ArrivedCityId = 1 });
            context.Clients.Add(new Client { Id = 11, PeopleId = 17, ArrivedCityId = 8 });
            context.Clients.Add(new Client { Id = 12, PeopleId = 18, ArrivedCityId = 9 });
            context.Clients.Add(new Client { Id = 13, PeopleId = 19, ArrivedCityId = 8 });
            context.Clients.Add(new Client { Id = 14, PeopleId = 20, ArrivedCityId = 10 });
        }

        // заполнение таблицы City
        private void InitilizeCity(HotelDb context) {
            context.Cities.Add(new City { Id = 1, Name = "Донецк" });
            context.Cities.Add(new City { Id = 2, Name = "Луганск" });
            context.Cities.Add(new City { Id = 3, Name = "Москва" });
            context.Cities.Add(new City { Id = 4, Name = "Липецк" });
            context.Cities.Add(new City { Id = 5, Name = "Таганрог" });
            context.Cities.Add(new City { Id = 6, Name = "Прага" });
            context.Cities.Add(new City { Id = 7, Name = "Варшава" });
            context.Cities.Add(new City { Id = 8, Name = "Калининград" });
            context.Cities.Add(new City { Id = 9, Name = "Макеевка" });
            context.Cities.Add(new City { Id = 10, Name = "Челябинск" });
        }

        // заполнение таблицы OrderStatus
        private void InitializeOrderStatus(HotelDb context) {
            context.OrderStatuses.Add(new OrderStatus { Id = _i++, Status = "Забронирован" });
            context.OrderStatuses.Add(new OrderStatus { Id = _i++, Status = "Заселен" });
            context.OrderStatuses.Add(new OrderStatus { Id = _i++, Status = "Выселен" });
            _i = 1;
        }

        // заполнение таблицы Order
        private void InitializeOrder(HotelDb context) {
            context.Orders.Add(new Order { Id = _i++, OrderStatusId = 2, ClientId = 1, DateIn = new DateTime(2022, 5, 1), DateOut = new DateTime(2022, 5, 22), RoomId = 1, Summ = 31500 });
            context.Orders.Add(new Order { Id = _i++, OrderStatusId = 2, ClientId = 2, DateIn = new DateTime(2022, 5, 1), DateOut = new DateTime(2022, 5, 22), RoomId = 2, Summ = 31500 });
            context.Orders.Add(new Order { Id = _i++, OrderStatusId = 2, ClientId = 3, DateIn = new DateTime(2022, 5, 1), DateOut = new DateTime(2022, 5, 22), RoomId = 3, Summ = 31500 });
            context.Orders.Add(new Order { Id = _i++, OrderStatusId = 2, ClientId = 4, DateIn = new DateTime(2022, 5, 11), DateOut = new DateTime(2022, 5, 28), RoomId = 4, Summ = 25500 });
            context.Orders.Add(new Order { Id = _i++, OrderStatusId = 2, ClientId = 5, DateIn = new DateTime(2022, 5, 8), DateOut = new DateTime(2022, 5, 22), RoomId = 5, Summ = 30800 });
            context.Orders.Add(new Order { Id = _i++, OrderStatusId = 2, ClientId = 6, DateIn = new DateTime(2022, 5, 7), DateOut = new DateTime(2022, 5, 15), RoomId = 6, Summ = 17600 });
            context.Orders.Add(new Order { Id = _i++, OrderStatusId = 2, ClientId = 7, DateIn = new DateTime(2022, 5, 4), DateOut = new DateTime(2022, 5, 19), RoomId = 11, Summ = 42000 });
            context.Orders.Add(new Order { Id = _i++, OrderStatusId = 2, ClientId = 8, DateIn = new DateTime(2022, 5, 1), DateOut = new DateTime(2022, 5, 12), RoomId = 12, Summ = 30000, Commentary = "По предоплате" });
            context.Orders.Add(new Order { Id = _i++, OrderStatusId = 3, ClientId = 9, DateIn = new DateTime(2022, 5, 12), DateOut = new DateTime(2022, 5, 31), RoomId = 12, Summ = 31500 });
            context.Orders.Add(new Order { Id = _i++, OrderStatusId = 2, ClientId = 10, DateIn = new DateTime(2022, 5, 10), DateOut = new DateTime(2022, 5, 22), RoomId = 14, Summ = 31500 });
            context.Orders.Add(new Order { Id = _i++, OrderStatusId = 2, ClientId = 11, DateIn = new DateTime(2022, 5, 19), DateOut = new DateTime(2022, 5, 27), RoomId = 15, Summ = 31500 });
            context.Orders.Add(new Order { Id = _i++, OrderStatusId = 1, ClientId = 1, DateIn = new DateTime(2022, 6, 1), DateOut = new DateTime(2022, 6, 14), RoomId = 20, Summ = 12500, Commentary = "Оплачено 30% от общей суммы" });
            context.Orders.Add(new Order { Id = _i++, OrderStatusId = 1, ClientId = 2, DateIn = new DateTime(2022, 5, 28), DateOut = new DateTime(2022, 6, 14), RoomId = 21, Summ = 31500 });
            _i = 1;
        }

        // заполнение таблицы Roommate
        private void InitializeRoommate(HotelDb context) {
            context.Roommates.Add(new Roommate { Id = _i++, OrderId = 5, ClientId = 6 });
            context.Roommates.Add(new Roommate { Id = _i++, OrderId = 5, ClientId = 8 });
            context.Roommates.Add(new Roommate { Id = _i++, OrderId = 11, ClientId = 13 });
            _i = 1;
        }

    }
}
