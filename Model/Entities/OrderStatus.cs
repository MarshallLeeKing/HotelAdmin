using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Model.Entities
{
    internal class OrderStatus {

        int Id { get; set; }
        string Status { get; set; }

        List<Order> Orders { get; set; } = new List<Order>();
    }
}
