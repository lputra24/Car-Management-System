﻿using CarManagementSystem.Data;
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

        public async Task<IEnumerable<Car>> GetAllCarAsync()
        {

            return await Context.Car.Include(b => b.VehicleType).ToListAsync();

        }

        



    }
}
