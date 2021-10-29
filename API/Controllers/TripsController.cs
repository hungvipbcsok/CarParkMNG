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
    public class TripsController : ControllerBase
    {
        private readonly ITrips _tripService;

        public TripsController(ITrips tripService)
        {
            _tripService = tripService;
        }


        [HttpGet("Get-Trip-ByID")]
        public async Task<IActionResult> GetTripById(int Id)
        {
            var trip = await _tripService.GetTripById(Id);

            return Ok(trip);
        }


        [HttpGet("List-All-Trip")]
        public async Task<IActionResult> GetAllTrip()
        {
            var allTrip = await _tripService.GetAllTrip().ConfigureAwait(false);

            return Ok(allTrip);
        }


        [HttpPost("Add-Trip")]
        public async Task<IActionResult> CreateTrip(Trip trip)
        {
            await _tripService.CreateTrip(trip).ConfigureAwait(false);
            return Ok();
        }


        [HttpPut("Update-Trip-ByID")]
        public async Task<IActionResult> UpdateTrip(int Id, Trip trip)
        {
            await _tripService.UpdateTrip(Id, trip).ConfigureAwait(false);

            return Ok();
        }


        [HttpDelete("Delete-Trip-ByID")]
        public async Task<IActionResult> DeleteTrip(int Id)
        {
            await _tripService.DeleteTrip(Id).ConfigureAwait(false);

            return Ok();
        }
    }
}
