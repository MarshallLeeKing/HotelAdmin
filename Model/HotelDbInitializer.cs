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

        // переопределяем метод для инициализации БД при первом обращении к ней
        protected override void Seed(HotelDb context)
        {
            InitializePeoples(context);
        }

        // заполнение таблицы Peoples
        private void InitializePeoples(HotelDb context)
        {
            context.Peoples.Add( new People { Name = "Иван",       Patronim = "Иванович",       Surname = "Иванов",     BirthDate = new DateTime(1970, 4, 24),  Male = true,  Passport = "ВТ 134421" });
            context.Peoples.Add( new People { Name = "Виктор",     Patronim = "Константинович", Surname = "Цой",        BirthDate = new DateTime(1968, 7, 12),  Male = true,  Passport = "ВА 154835" });
            context.Peoples.Add( new People { Name = "Ольга",      Patronim = "Денисовна",      Surname = "Акименко",   BirthDate = new DateTime(1987, 1, 19),  Male = false, Passport = "ВА 554289" });
            context.Peoples.Add( new People { Name = "Матильда",   Patronim = "Геогиевна",      Surname = "Позднякова", BirthDate = new DateTime(1997, 8, 1),   Male = false, Passport = "ДА 135482" });
            context.Peoples.Add( new People { Name = "Лолита",     Patronim = "Павловна",       Surname = "Вуйчич",     BirthDate = new DateTime(1980, 5, 20),  Male = false, Passport = "ДД 218745" });
            context.Peoples.Add( new People { Name = "Владимир",   Patronim = "Олегович",       Surname = "Яровой",     BirthDate = new DateTime(1979, 3, 11),  Male = true,  Passport = "ВУ 552182" });
            context.Peoples.Add( new People { Name = "Анатолий",   Patronim = "Викторович",     Surname = "Резник",     BirthDate = new DateTime(1985, 8, 25),  Male = true,  Passport = "ВТ 656842" });
            context.Peoples.Add( new People { Name = "Марина",     Patronim = "Олеговна",       Surname = "Петропа",    BirthDate = new DateTime(1999, 7, 9),   Male = false, Passport = "ВТ 552486" });
            context.Peoples.Add( new People { Name = "Дмитрий",    Patronim = "Максимович",     Surname = "Гагулин",    BirthDate = new DateTime(2001, 1, 10),  Male = true,  Passport = "ВТ 112548" });
            context.Peoples.Add( new People { Name = "Карина",     Patronim = "Альбертовна",    Surname = "Тигенская",  BirthDate = new DateTime(1966, 9, 20),  Male = false, Passport = "ВЛ 354984" });
            context.Peoples.Add( new People { Name = "Лариса",     Patronim = "Вячеславовна",   Surname = "Салова",     BirthDate = new DateTime(1989, 12, 21), Male = false, Passport = "ВУ 135490" });
            context.Peoples.Add( new People { Name = "Павел",      Patronim = "Павлович",       Surname = "Салов",      BirthDate = new DateTime(1985, 11, 17), Male = true,  Passport = "ВЕ 210548" });
            context.Peoples.Add( new People { Name = "Юрий",       Patronim = "Инокентиевич",   Surname = "Семенов",    BirthDate = new DateTime(1990, 12, 18), Male = true,  Passport = "ВТ 221659" });
            context.Peoples.Add( new People { Name = "Милана",     Patronim = "Тихоновна",      Surname = "Салова",     BirthDate = new DateTime(2015, 10, 19), Male = false, Passport = "ВТ 336591" });
            context.Peoples.Add( new People { Name = "Ксения",     Patronim = "Николаевна",     Surname = "Метрич",     BirthDate = new DateTime(1988, 9, 21),  Male = false, Passport = "ВТ 369015" });
            context.Peoples.Add( new People { Name = "Олег",       Patronim = "Романович",      Surname = "Липа",       BirthDate = new DateTime(1971, 8, 17),  Male = true,  Passport = "ВТ 752016" });
            context.Peoples.Add( new People { Name = "Константин", Patronim = "Олегович",       Surname = "Дудин",      BirthDate = new DateTime(1980, 6, 11),  Male = true,  Passport = "ВТ 126509" });
            context.Peoples.Add( new People { Name = "Максим",     Patronim = "Петрович",       Surname = "Рувинский",  BirthDate = new DateTime(1998, 7, 10),  Male = true,  Passport = "ВТ 898540" });
            context.Peoples.Add( new People { Name = "Людмила",    Patronim = "Романовна",      Surname = "Дудина",     BirthDate = new DateTime(1981, 8, 8),   Male = false, Passport = "ВТ 698422" });
            context.Peoples.Add( new People { Name = "Тамара",     Patronim = "Тихоновна",      Surname = "Рувинская",  BirthDate = new DateTime(1970, 3, 2),   Male = false, Passport = "ВТ 885172" });
        }

    }
}
