namespace HotelAdmin.Model.Entities
{
    // данные о сожителях в номере
    public class Roommate {

        public int Id { get; set; }

        // связь с таблицей заказов
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        // связь с таблицей Клиентов
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}