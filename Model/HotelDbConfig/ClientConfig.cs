using HotelAdmin.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Model.HotelDbConfig {
    internal class ClientConfig : EntityTypeConfiguration<Client> {

        public ClientConfig() {

            HasKey(x => x.Id);

            HasRequired(p => p.People);

            HasRequired(c => c.ArrivedCity);

        }

    }
}
