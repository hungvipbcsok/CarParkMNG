using Microsoft.AspNetCore.Mvc;
using Model.Entity;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICars _carService;

        public CarsController(ICars carService)
        {
            _carService = carService;
        }


        [HttpGet("Get-Car-ByID")]
        public async Task<IActionResult> GetCarById(string lincesplate)
        {
            var car = await _carService.GetCarById(lincesplate);

            return Ok(car);
        }


        [HttpGet("List-All-Car")]
        public async Task<IActionResult> GetAllCar()
        {
            var allCar = await _carService.GetAllCar().ConfigureAwait(false);

            return Ok(allCar);
        }


        [HttpPost("Add-Car")]
        public async Task<IActionResult> CreateCar([FromBody] Car car)
        {
            await _carService.CreateCar(car).ConfigureAwait(false);
            return Ok();
        }


        [HttpPut("Update-Car-ByID")]
        public async Task<IActionResult> UpdateCar(string lincesplate, Car car)
        {
            await _carService.UpdateCar(lincesplate, car).ConfigureAwait(false);

            return Ok();
        }


        [HttpDelete("Delete-Car-ByID")]
        public async Task<IActionResult> DeleteCar(string lincesplate)
        {
            await _carService.DeleteCar(lincesplate).ConfigureAwait(false);

            return Ok();
        }
    }
}
