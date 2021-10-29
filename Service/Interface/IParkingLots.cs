using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IParkingLots
    {
        public Task CreateParkingLot(ParkingLot request);
        public Task DeleteParkingLot(int Id);
        public Task<List<ParkingLot>> GetAllParkingLot();
        public Task<ParkingLot> GetParkingLotById(int Id);
        public Task UpdateParkingLot(int Id, ParkingLot request);
    }
}
