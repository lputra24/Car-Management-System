﻿using AutoMapper;
using CarManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarManagementSystem.DataTransferObjects
{
    public class MappingProfile : Profile
    {
        public MappingProfile(){
            CreateMap<Car,CarDTO>();
            CreateMap<VehicleType, VehicleTypeDTO>();
            CreateMap<CarForCreationDTO, Car>();
        }
    }
}
