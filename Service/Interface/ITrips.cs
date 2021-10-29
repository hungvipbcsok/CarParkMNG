using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ITrips
    {
        public Task CreateTrip(Trip request);
        public Task DeleteTrip(int Id);
        public Task<List<Trip>> GetAllTrip();
        public Task<Trip> GetTripById(int Id);
        public Task UpdateTrip(int Id, Trip request);
    }
}
