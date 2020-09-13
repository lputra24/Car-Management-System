using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public WeatherForecastController(IRepositoryManager repository) {
            _repository = repository;
        }
        
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return _repository.Car.GetAll();
        }
    }
}
