using Model.Entity;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implemention
{
    public class TicketService : ITickets
    {
        private readonly IGenericService<Ticket> _tickets;

        public TicketService(IGenericService<Ticket> tickets)
        {
            _tickets = tickets;
        }


        public async Task CreateTicket(Ticket request)
        {
            var _ticket = new Ticket()
            {
                CustomerName = request.CustomerName,
                TripId = request.TripId,
                LicensePlate = request.LicensePlate,

            };

            await _tickets.Create(_ticket).ConfigureAwait(false);

        }

        public async Task DeleteTicket(int Id)
        {
            var _ticket = await _tickets.GetId(Id);

            await _tickets.Delete(_ticket).ConfigureAwait(false);
        }


        public async Task<List<Ticket>> GetAllTicket()
        {
            return await _tickets.GetAll().ConfigureAwait(false);
        }


        public async Task<Ticket> GetTicketById(int Id)
        {
            return await _tickets.GetId(Id);
        }


        public async Task UpdateTicket(int Id, Ticket request)
        {
            var _ticket = await _tickets.GetId(Id);

            if (_ticket != null)
            {
                _ticket.CustomerName = request.CustomerName;
                _ticket.TripId = request.TripId;
                _ticket.LicensePlate = request.LicensePlate;

                await _tickets.Update(_ticket).ConfigureAwait(false);

            }
        }
    }
}
