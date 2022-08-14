using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Model.Entities
{
    public class OrderStatus {

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual List<Order> Orders { get; set; } = new List<Order>();
    }
}
