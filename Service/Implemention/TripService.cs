using Model.Entity;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implemention
{
    public class TripService : ITrips
    {
        private readonly IGenericService<Trip> _tripRespository;

        public TripService(IGenericService<Trip> tripRespository)
        {
            _tripRespository = tripRespository;
        }


        public async Task CreateTrip(Trip request)
        {
            var _trip = new Trip()
            {
                Destination = request.Destination,
                Driver = request.Driver,
                CarType = request.CarType,
                BookedTicketNumber = request.BookedTicketNumber,
                MaxTicketNumber = request.MaxTicketNumber,
                DepartureDate = request.DepartureDate,
                DepartureTime = request.DepartureTime

            };

            await _tripRespository.Create(_trip).ConfigureAwait(false);
        }


        public async Task DeleteTrip(int Id)
        {
            var _trip = await _tripRespository.GetId(Id);

            await _tripRespository.Delete(_trip).ConfigureAwait(false);
        }


        public async Task<List<Trip>> GetAllTrip()
        {
            return await _tripRespository.GetAll().ConfigureAwait(false);
        }

        public async Task<Trip> GetTripById(int Id)
        {
            return await _tripRespository.GetId(Id);
        }

        public async Task UpdateTrip(int Id, Trip request)
        {
            var _trip = await _tripRespository.GetId(Id);

            if (_trip != null)
            {
                _trip.Destination = request.Destination;              
                _trip.Driver = request.Driver;
                _trip.CarType = request.CarType;
                _trip.BookedTicketNumber = request.BookedTicketNumber;
                _trip.MaxTicketNumber = request.MaxTicketNumber;
                _trip.DepartureDate = request.DepartureDate;
                _trip.DepartureTime = request.DepartureTime;
                await _tripRespository.Update(_trip).ConfigureAwait(false);

            }
        }
    }
}
