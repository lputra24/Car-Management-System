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
        public async Task<IActionResult> GetAllCar()
        {

            var cars = await _repository.Car.GetAllCarAsync();
            var carsForView = _mapper.Map<IEnumerable<CarForViewDTO>>(cars);
            return Ok(carsForView);

        }

        [HttpPost]
        public async Task<IActionResult> CreateCar([FromBody] CarForCreationDTO car)
        {
            if (car == null) {
                return BadRequest("parameter car is empty");
            }
            if (!ModelState.IsValid) {
                return UnprocessableEntity("Invalid model state for the car input object");
            }

            Car carToAdd = _mapper.Map<Car>(car);
            _repository.Car.Add(carToAdd);
            await _repository.SaveAsync();
            CarForViewDTO carCreated = _mapper.Map<CarForViewDTO>(carToAdd);
            return Ok(carCreated);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar(int id) {
            var car = await _repository.Car.GetCarByIdAsync(id);
            if (car==null) {
                return NotFound("The specified car does not exist, please refresh");
            }
            _repository.Car.Remove(car);
            await _repository.SaveAsync();
            return NoContent();
        }
    }
}