using HotelAdmin.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Model.HotelDbConfig {
    internal class CleaningTimeConfig : EntityTypeConfiguration<CleaningTime> {

        public CleaningTimeConfig() {
            HasKey(x => x.Id);

            HasRequired(c => c.Employee);

            HasRequired(r => r.Room);
        }

    }
}
