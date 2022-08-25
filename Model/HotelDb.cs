using HotelAdmin.Model.Entities;
using System;
using System.Data.Entity;
using System.Linq;

using HotelAdmin.Model.HotelDbConfig;
using System.Data.Entity.ModelConfiguration.Conventions;

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

        // данные о городах
        public DbSet<City> Cities { get; set; }

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


        protected override void OnModelCreating(DbModelBuilder modelBuilder) {

            // решаем проблему каскадного удаления таблиц при наличии нескольких связанных таблиц по иерархии
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            // конфигурирование таблиц к БД
            modelBuilder.Configurations.Add(new PeopleConfig());
            modelBuilder.Configurations.Add(new ClientConfig());
            modelBuilder.Configurations.Add(new EmployeeConfig());
            modelBuilder.Configurations.Add(new EmployeeStatusConfig());
            modelBuilder.Configurations.Add(new CityConfig());
            modelBuilder.Configurations.Add(new RoomConfig());
            modelBuilder.Configurations.Add(new PriceGroupConfig());
            modelBuilder.Configurations.Add(new CleaningTimeConfig());
            modelBuilder.Configurations.Add(new EmployeesWorkHistoryConfig());

        }

    }
}