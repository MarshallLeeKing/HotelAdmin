using HotelAdmin.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Model.HotelDbConfig {
    internal class CityConfig : EntityTypeConfiguration<City> {

        public CityConfig() {

            HasMany(c => c.Clients)
                    .WithRequired(c => c.ArrivedCity);
        }

    }
}
