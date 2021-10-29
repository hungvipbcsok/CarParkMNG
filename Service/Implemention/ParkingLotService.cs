using Model.Entity;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implemention
{
    public class ParkingLotService : IParkingLots
    {
        private readonly IGenericService<ParkingLot> _parkingLots;
        public ParkingLotService(IGenericService<ParkingLot> parkingLots)
        {
            _parkingLots = parkingLots;
        }


        public async Task CreateParkingLot(ParkingLot request)
        {
            var _parkingLot = new ParkingLot()
            {
                Name = request.Name,
                Place = request.Place,
                Area = request.Area,
                Status = request.Status,
                Price = request.Price,
                

            };
            await _parkingLots.Create(_parkingLot).ConfigureAwait(false);
        }


        public async Task DeleteParkingLot(int Id)
        {
            var _packingLot = await _parkingLots.GetId(Id);

            await _parkingLots.Delete(_packingLot).ConfigureAwait(false);
        }

        public async Task<List<ParkingLot>> GetAllParkingLot()
        {
            return await _parkingLots.GetAll().ConfigureAwait(false);
        }

        public async Task<ParkingLot> GetParkingLotById(int Id)
        {
            return await _parkingLots.GetId(Id);
        }

        public async Task UpdateParkingLot(int Id, ParkingLot request)
        {
            var _parkingLot = await _parkingLots.GetId(Id);

            if (_parkingLot != null)
            {
                _parkingLot.Name = request.Name;
                _parkingLot.Place = request.Place;
                _parkingLot.Area = request.Area;
                _parkingLot.Status = request.Status;
                _parkingLot.Price = request.Price;

                await _parkingLots.Update(_parkingLot).ConfigureAwait(false);

            }
        }
    }
}
