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
    public class ParkingLotsController : ControllerBase
    {
        private readonly IParkingLots _packingLotService;
        public ParkingLotsController(IParkingLots packingLotService)
        {
            _packingLotService = packingLotService;
        }


        [HttpGet("Get-Parking Lot-ByID")]
        public async Task<IActionResult> GetPackingLotById(int Id)
        {
            var _packingLot = await _packingLotService.GetParkingLotById(Id);

            return Ok(_packingLot);
        }


        [HttpGet("List-Parking Lot")]
        public async Task<IActionResult> GetAllPackingLot()
        {
            var _allPackingLot = await _packingLotService.GetAllParkingLot().ConfigureAwait(false);

            return Ok(_allPackingLot);
        }


        [HttpPost("Add-Parking Lot")]
        public async Task<IActionResult> CreatePackingLot(ParkingLot packingLot)
        {
            await _packingLotService.CreateParkingLot(packingLot).ConfigureAwait(false);
            return Ok();
        }


        [HttpPut("Update-Parking Lot-ByID")]
        public async Task<IActionResult> UpdatePackingLot(int Id, ParkingLot packingLot)
        {
            await _packingLotService.UpdateParkingLot(Id, packingLot).ConfigureAwait(false);

            return Ok();
        }


        [HttpDelete("Delete-Parking Lot-ByID")]
        public async Task<IActionResult> DeletePackingLot(int Id)
        {
            await _packingLotService.DeleteParkingLot(Id).ConfigureAwait(false);

            return Ok();
        }
    }
}
