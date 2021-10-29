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
    public class TicketsController : ControllerBase
    {
        private readonly ITickets _ticketService;

        public TicketsController(ITickets ticketService)
        {
            _ticketService = ticketService;
        }


        [HttpGet("Get-Ticket-ByID")]
        public async Task<IActionResult> GetTicketById(int Id)
        {
            var ticket = await _ticketService.GetTicketById(Id);

            return Ok(ticket);
        }


        [HttpGet("List-All-Ticket")]
        public async Task<IActionResult> GetAllTicket()
        {
            var allTicket = await _ticketService.GetAllTicket().ConfigureAwait(false);

            return Ok(allTicket);
        }


        [HttpPost("Add-Ticket")]
        public async Task<IActionResult> CreateTicket(Ticket ticket)
        {
            await _ticketService.CreateTicket(ticket).ConfigureAwait(false);
            return Ok();
        }


        [HttpPut("Update-Ticket-ByID")]
        public async Task<IActionResult> UpdateTicket(int Id, Ticket ticket)
        {
            await _ticketService.UpdateTicket(Id, ticket).ConfigureAwait(false);

            return Ok();
        }


        [HttpDelete("Delete-Ticket-ByID")]
        public async Task<IActionResult> DeleteTicket(int Id)
        {
            await _ticketService.DeleteTicket(Id).ConfigureAwait(false);

            return Ok();
        }
    }
}
