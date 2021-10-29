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
    public class BookingOfficesController : ControllerBase
    {
        private readonly IBookingOffices _bookingOfficeService;

        public BookingOfficesController(IBookingOffices bookingOfficeService)
        {
            _bookingOfficeService = bookingOfficeService;
        }


        [HttpGet("Get-Booking Office-ByID")]
        public async Task<IActionResult> GetBookingOfficeById(int Id)
        {
            var bookingOffice = await _bookingOfficeService.GetBookingById(Id);

            return Ok(bookingOffice);
        }


        [HttpGet("List-Booking Office")]
        public async Task<IActionResult> GetAllBookingOffice()
        {
            var allBookingOffice = await _bookingOfficeService.GetAllBooking().ConfigureAwait(false);

            return Ok(allBookingOffice);
        }


        [HttpPost("Add-Booking Ofice")]
        public async Task<IActionResult> CreateCar(BookingOffice car)
        {
            await _bookingOfficeService.CreateBooking(car).ConfigureAwait(false);
            return Ok();
        }


        [HttpPut("Update-Booking Office-ByID")]
        public async Task<IActionResult> UpdateBookingOffice(int Id, BookingOffice bookingOffice)
        {
            await _bookingOfficeService.UpdateBooking(Id, bookingOffice).ConfigureAwait(false);

            return Ok();
        }


        [HttpDelete("Delete-Booking Office-ByID")]
        public async Task<IActionResult> DeleteBookingOffice(int Id)
        {
            await _bookingOfficeService.DeleteBooking(Id).ConfigureAwait(false);

            return Ok();
        }
    }
}
