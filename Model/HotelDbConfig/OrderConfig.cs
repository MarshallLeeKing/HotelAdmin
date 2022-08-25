using HotelAdmin.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Model.HotelDbConfig {
    internal class OrderConfig : EntityTypeConfiguration<Order> {

        public OrderConfig() {

            HasKey(x => x.Id);

            HasRequired(c => c.Client);
            HasRequired(c => c.Room);
            HasRequired(c => c.OrderStatus);

            HasMany(r => r.Rommates)
                .WithRequired(o => o.Order);

        }

    }
}
