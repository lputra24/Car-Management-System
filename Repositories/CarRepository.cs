using CarManagementSystem.Data;
using CarManagementSystem.DataTransferObjects;
using CarManagementSystem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarManagementSystem.Repositories
{
    public class CarRepository : RepositoryBase<Car>, ICarRepository
    {
        public CarRepository(RepositoryContext context) : base(context) { }

        public void CreateCar(Car car)
        {
            Add(car);
        }

        public IEnumerable GetAllCar()
        {
            return Context.Car.Join(Context.VehicleType,
                Car => Car.VehicleTypeId, VehicleType => VehicleType.Id, (Car, VehicleType) =>
                      new CarForViewDTO {Id = Car.Id,
                          Type = VehicleType.Type,
                          Make = Car.Make,
                          Model = Car.Model,
                          Engine = Car.Engine,
                          Doors = Car.Doors,
                          Wheels = Car.Wheels,
                          BodyType = Car.BodyType
                      }).ToList();
        }

    }
}
