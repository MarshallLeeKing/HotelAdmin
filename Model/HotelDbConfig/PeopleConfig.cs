using HotelAdmin.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace HotelAdmin.Model.HotelDbConfig {
    internal class PeopleConfig : EntityTypeConfiguration<People> {

        public PeopleConfig() {

            HasKey(x => x.Id);

            HasOptional<Client>(p => p.Client)
            .WithRequired(p => p.People);
             
            HasOptional<Employee>(p => p.Employee)
            .WithRequired(p => p.People);

        }

    }
}
