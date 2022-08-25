using System;
using System.Collections.Generic;

namespace HotelAdmin.Model.Entities
{
    // Таблица заказов номеров
    public class Order {

        public int Id { get; set; }

        // дата заселения
        public DateTime DateIn { get; set; }

        // дата выселения
        public DateTime DateOut { get; set; }

        // сумма к оплате
        public double? Summ { get; set; }

        // комментарии к заказу
        public string Commentary { get; set; }

        // связь с таблицей клиентов
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        // связь с таблицей комнат
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }

        // связь с таблицей статусов заказа
        public int OrderStatusId { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }

        // связь с таблицей сожителей
        public virtual List<Roommate> Rommates { get; set; } = new List<Roommate>();
    }
}