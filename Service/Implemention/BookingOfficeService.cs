using Model.Entity;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implemention
{
    public class BookingOfficeService : IBookingOffices
    {
        private readonly IGenericService<BookingOffice> _bookingOffices;

        public BookingOfficeService(IGenericService<BookingOffice> bookingOffices)
        {
            _bookingOffices = bookingOffices;
        }


        public async Task CreateBooking(BookingOffice request)
        {
            var _bookingOffice = new BookingOffice()
            {
                OfficeName = request.OfficeName,
                Phone = request.Phone,
                TripId = request.TripId,
                Price = request.Price,
                Place = request.Place,
                ContractEnd = request.ContractEnd,
                ContractStart = request.ContractStart

            };

            await _bookingOffices.Create(_bookingOffice).ConfigureAwait(false);
        }


        public async Task DeleteBooking(int Id)
        {
            var _bookingOffice = await _bookingOffices.GetId(Id);

            await _bookingOffices.Delete(_bookingOffice).ConfigureAwait(false);
        }


        public async Task<List<BookingOffice>> GetAllBooking()
        {
            return await _bookingOffices.GetAll().ConfigureAwait(false);
        }


        public async Task<BookingOffice> GetBookingById(int Id)
        {
            return await _bookingOffices.GetId(Id);
        }


        public async Task UpdateBooking(int Id, BookingOffice request)
        {
            var _bookingOffice = await _bookingOffices.GetId(Id);

            if (_bookingOffice != null)
            {
                _bookingOffice.OfficeName = request.OfficeName;
                _bookingOffice.Phone = request.Phone;
                _bookingOffice.Price = request.Price;
                _bookingOffice.Place = request.Place;
                _bookingOffice.TripId = request.TripId;
                _bookingOffice.ContractStart = request.ContractStart;
                _bookingOffice.ContractEnd = request.ContractEnd;

                await _bookingOffices.Update(_bookingOffice).ConfigureAwait(false);
            }
        }
    }
}
