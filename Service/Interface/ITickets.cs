using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ITickets
    {
        public Task CreateTicket(Ticket request);
        public Task DeleteTicket(int Id);
        public Task<List<Ticket>> GetAllTicket();
        public Task<Ticket> GetTicketById(int Id);
        public Task UpdateTicket(int Id, Ticket request);
    }
}
