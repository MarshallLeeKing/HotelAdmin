using HotelAdmin.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Model.HotelDbConfig {
    internal class EmployeeStatusConfig : EntityTypeConfiguration<EmployeeStatus> {

        public EmployeeStatusConfig() {

            HasKey(x => x.Id);

            HasMany(e => e.Employees)
                .WithRequired(s => s.EmployeeStatus);

            HasMany(e => e.EmployeesWorkHistories)
                .WithRequired(s => s.EmployeeStatus);

        }

    }
}
