﻿using CarManagementSystem.Data;
using CarManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarManagementSystem.Repositories
{
    public class VehicleTypeRepository : RepositoryBase<VehicleType>,IVehicleTypeRepository
    {
        public VehicleTypeRepository(RepositoryContext context) : base(context) { }
    }
}
