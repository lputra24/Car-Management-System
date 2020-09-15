using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarManagementSystem.DataTransferObjects;
using CarManagementSystem.Models;
using CarManagementSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public CarController(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable Get()
        {

            return _repository.Car.GetAllCar();

        }

        [HttpPost]
        public IActionResult CreateCar([FromForm] CarForCreationDTO car)
        {

            var carEntity = _mapper.Map<Car>(car);
            _repository.Car.Add(carEntity);
            _repository.Save();
            return Ok(carEntity);

        }
    }
}