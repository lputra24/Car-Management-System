using CarManagementSystem.DataTransferObjects;
using CarManagementSystem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarManagementSystem.Repositories
{
    public interface ICarRepository : IRepositoryBase<Car>
    {
        Task<IEnumerable<Car>> GetAllCarAsync();
        void CreateCar(Car car);
        void DeleteCar(Car car);
    }
}
