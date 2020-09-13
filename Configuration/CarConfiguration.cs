using CarManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarManagementSystem.Configuration
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasData(
                new Car { 
                    Id = 1,
                    VehicleTypeId = 1,
                    Make = "alfa romeo",
                    Model = "veloce",
                    Engine = "2.0T Petrol 8 sp Automatic RWD",
                    Doors = 4,
                    Wheels = 4,
                    BodyType = "sedan"
                },
                new Car
                {
                    Id = 2,
                    VehicleTypeId = 1,
                    Make = "hyundai",
                    Model = "active",
                    Engine = "2.0DT Diesel 8 sp Automatic 4x4",
                    Doors = 5,
                    Wheels = 4,
                    BodyType = "suv"
                },
                new Car
                {
                    Id=3,
                    VehicleTypeId = 1,
                    Make = "volkswagen",
                    Model = "70tsi trendline",
                    Engine = "1.0T Petrol 5 sp Manual FWD",
                    Doors = 5,
                    Wheels = 4,
                    BodyType = "hatch"
                }
            );
            
        }
    }
}
