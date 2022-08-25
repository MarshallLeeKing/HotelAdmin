using HotelAdmin.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Model.HotelDbConfig {
    internal class OrderStatusConfig : EntityTypeConfiguration<OrderStatus> {

        public OrderStatusConfig() {

            HasKey(x => x.Id);

            HasMany(x => x.Orders)
                .WithRequired(o => o.OrderStatus);

        }

    }
}
