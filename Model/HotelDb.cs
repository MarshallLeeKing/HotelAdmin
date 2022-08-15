using HotelAdmin.Model.Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace HotelAdmin.Model
{
    public class HotelDb : DbContext
    {
        
        public HotelDb() : base("name=HotelDb") { 
            Database.SetInitializer(new HotelDbInitializer());
        }

        public HotelDb(string connectionString) : base(connectionString)
        {
            Database.SetInitializer(new HotelDbInitializer());
        }

        #region Таблицы базы данных

        // расписание уборки
        public DbSet<CleaningTime> CleaningTimes { get; set; }
        
        // данные о клиентах
        public DbSet<Client> Clients { get; set; }
        
        // данные о сотрудниках
        public DbSet<Employee> Employees { get; set; }

        // данные о статусах сотрудников
        public DbSet<EmployeeStatus> EmployeeStatuses { get; set; }

        // таблица — табель рабочего времени
        public DbSet<EmployeesTimesheet> EmployeeTimesheets { get; set; }
        
        // данные о истории выплат сотрудникам
        public DbSet<EmployeesWorkHistory> EmployeesWorkHistories { get; set; }

        // данные о заказах
        public DbSet<Order> Orders { get; set; }
        
        // статусы заказа
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        
        // персональные данные
        public DbSet<People> Peoples { get; set; }
        
        // категории цен
        public DbSet<PriceGroup> PriceGroups { get; set; }
        
        // информация о номерах гостиницы
        public DbSet<Room> Rooms { get; set; }
        
        // информация о сожителях главного клиента
        public DbSet<Roommate> Roommates { get; set; }

        #endregion


    }
}