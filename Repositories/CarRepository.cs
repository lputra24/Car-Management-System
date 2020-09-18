using CarManagementSystem.Data;
using CarManagementSystem.DataTransferObjects;
using CarManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
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
        public void DeleteCar(Car car)
        {
            Remove(car);
        }

        public async Task<IEnumerable<Car>> GetAllCarAsync()
        {

            return await Context.Car.Include(b => b.VehicleType).ToListAsync();

        }

        public async Task<Car> GetCarByIdAsync(int id)
        {
            return await Context.Car.FindAsync(id);
        }
    }
}
