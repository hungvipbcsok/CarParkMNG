using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IBookingOffices
    {
        public Task CreateBooking(BookingOffice request);
        public Task<List<BookingOffice>> GetAllBooking();
        public Task<BookingOffice> GetBookingById(int Id);
        public Task UpdateBooking(int Id, BookingOffice request);
        public Task DeleteBooking(int Id);
    }
}
