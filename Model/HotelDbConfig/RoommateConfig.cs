using HotelAdmin.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Model.HotelDbConfig {
    internal class RoommateConfig : EntityTypeConfiguration<Roommate> {

        public RoommateConfig() {

            HasKey(x => x.Id);

            HasRequired(c => c.Client);
            HasRequired(o => o.Order);

        }

    }
}
