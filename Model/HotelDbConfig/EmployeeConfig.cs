using HotelAdmin.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Model.HotelDbConfig {
    internal class EmployeeConfig : EntityTypeConfiguration<Employee> {

        public EmployeeConfig() {

            HasKey(x => x.Id);

            HasRequired(p => p.People);

            HasMany(ts => ts.EmployeesTimesheets)
                .WithRequired(x => x.Employee);

            HasMany(e => e.EmployeesWorkHistories)
                .WithRequired(x => x.Employee);

        }

    }
}
