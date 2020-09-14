using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarManagementSystem.DataTransferObjects;
using CarManagementSystem.Models;
using CarManagementSystem.Repositories;
using CarManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CarManagementSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public WeatherForecastController(IRepositoryManager repository, IMapper mapper) {
            _repository = repository;
            _mapper = mapper;
        }
        
        [HttpGet]
        public IEnumerable<CarForViewDTO> Get()
        {
            
            return _repository.Car.GetAllCar();
            
        }
    }
}
