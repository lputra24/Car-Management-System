using AutoMapper;
using CarManagementSystem.Controllers;
using CarManagementSystem.DataTransferObjects;
using CarManagementSystem.Models;
using CarManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace web_api_tests.Controller
{
    public class CarControllerTest
    {
        private readonly Mock<IRepositoryManager> _mockRepo;
        private readonly CarController _controller;
        private readonly Mock<IMapper> _mockMapper;

        public CarControllerTest(){
            _mockRepo = new Mock<IRepositoryManager>();
            _mockMapper = new Mock<IMapper>();
            _controller = new CarController(_mockRepo.Object,_mockMapper.Object);
        }


        [Fact]
        public async Task GetAllCar_ActionExecutes_ReturnsTaskIActionResult()
        {
            var car = new Mock<Car>();
            var cars = new List<Car>();
            _mockRepo.Setup(repo => repo.Car.GetAllCarAsync())
            .ReturnsAsync(cars);
      
            var result = await _controller.GetAllCar();
            Assert.IsType<OkObjectResult>(result);

        }

        [Fact]
        public async Task CreateCar_ActionExecutes_Success_Returns_StatusCodeOk()
        {
 
            CarForCreationDTO carToBeCreated = new CarForCreationDTO
            {
               
                Make = "honda",
                Model = "civic",
                Engine = "2.0 T petrol",
                Doors = 4,
                Wheels = 4,
                BodyType = "sedan"
                
            };

            Car carCreated = new Car
            {
                VehicleTypeId = 1,
                Make = "honda",
                Model = "civic",
                Engine = "2.0 T petrol",
                Doors = 4,
                Wheels = 4,
                BodyType = "sedan"

            };

            _mockRepo.Setup(repo => repo.Car.CreateCar(carCreated));
            

            _mockRepo.Setup(repo => repo.SaveAsync())
            .Returns(Task.CompletedTask)
            .Verifiable();

            var result = await _controller.CreateCar(carToBeCreated);
            Assert.IsType<OkObjectResult>(result);
            
        }

        [Fact]
        public async Task CreateCar_ActionExecutes_Null_Returns_BadRequest()
        {
            _mockRepo.Setup(repo => repo.Car.CreateCar(null));


            _mockRepo.Setup(repo => repo.SaveAsync())
            .Returns(Task.CompletedTask)
            .Verifiable();
            var result = await _controller.CreateCar(null);
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task CreateCar_ActionExecutes_invalidModel_Returns_Unprocessed()
        {
            _controller.ModelState.AddModelError("Make", "Required");
            CarForCreationDTO carToBeCreated = new CarForCreationDTO
            {

               
                Model = "civic",
                Engine = "2.0 T petrol",
                Doors = 4,
                Wheels = 4,
                BodyType = "sedan"

            };
            var result = await _controller.CreateCar(carToBeCreated);
            Assert.IsType<UnprocessableEntityObjectResult>(result);

        }

       


    }
}
