using AutoMapper;
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
            CreateMap<Car, CarForViewDTO>().ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.VehicleType.Type));
            CreateMap<CarForCreationDTO, Car>();
        }
    }
}
