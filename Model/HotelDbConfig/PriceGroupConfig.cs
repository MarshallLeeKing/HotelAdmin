﻿using HotelAdmin.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Model.HotelDbConfig {
    internal class PriceGroupConfig : EntityTypeConfiguration<PriceGroup> {

        public PriceGroupConfig() {

            HasKey(x => x.Id);

            HasMany(r => r.Rooms)
                .WithRequired(p => p.PriceGroup);

        }

    }
}
