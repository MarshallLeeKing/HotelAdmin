using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Model.Entities
{
    // таблица статусов заказов
    public class OrderStatus {

        public int Id { get; set; }
        public string Status { get; set; }

        // связь с таблицей Orders
        public virtual List<Order> Orders { get; set; } = new List<Order>();
    }
}
