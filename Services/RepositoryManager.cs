using CarManagementSystem.Data;
using CarManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarManagementSystem.Services
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private ICarRepository _vehicleRepository;
        private IVehicleTypeRepository _vehicleTypeRepository;

        public RepositoryManager(RepositoryContext context) {
            _repositoryContext = context;
        }

        public ICarRepository Car {
            get
            {
                if (_vehicleRepository == null) {
                    _vehicleRepository = new CarRepository(_repositoryContext);
                }
                return _vehicleRepository;
            }
        }

        public IVehicleTypeRepository VehicleType
        {
            get
            {
                if (_vehicleTypeRepository == null)
                {
                    _vehicleTypeRepository = new VehicleTypeRepository(_repositoryContext);
                }
                return _vehicleTypeRepository;
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
