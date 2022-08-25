using HotelAdmin.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Model.HotelDbConfig {
    internal class RoomConfig : EntityTypeConfiguration<Room> {

        public RoomConfig() {

            HasKey(x => x.Id);

            HasRequired(p => p.PriceGroup);

            HasMany(c => c.CleaningTimes)
                .WithRequired(c => c.Room);

        }

    }
}
