using CarManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarManagementSystem.Services
{
    public interface IRepositoryManager
    {
        ICarRepository Car { get; }
        IVehicleTypeRepository VehicleType { get; }
        void Save();
    }
}
