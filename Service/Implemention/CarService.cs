using Model.Context;
using Model.Entity;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implemention
{
    public class CarService : ICars
    {
        private readonly IGenericService<Car> _cars;
        private readonly CarBookingContext _dbContext;

        public CarService(IGenericService<Car> cars, CarBookingContext dbContext)
        {
            _cars = cars;
            _dbContext = dbContext;
        }

        public async Task<Car> GetId(string request)
        {
            //Get data by Id from SQl Server
            return await _dbContext.Set<Car>().FindAsync(request);

        }

        public async Task CreateCar(Car request)
        {
            var _car = new Car()
            {
                LicensePlate = request.LicensePlate,
                Type = request.Type,
                Color = request.Color,
                Company = request.Company,
                ParkingLotId = request.ParkingLotId

            };
            await _cars.Create(_car).ConfigureAwait(false);

        }


        public async Task DeleteCar(string lincensplate)
        {
            var _car = await GetId(lincensplate);

            await _cars.Delete(_car).ConfigureAwait(false);

        }


        public async Task<List<Car>> GetAllCar()
        {

            return await _cars.GetAll().ConfigureAwait(false);

        }
       

        public async Task<Car> GetCarById(string lincensplate)
        {

            return await GetId(lincensplate);

        }


        public async Task UpdateCar(string lincensplate, Car request)
        {
            var _car = await GetId(lincensplate);

            if (_car != null)
            {
                _car.Type = request.Type;
                _car.Color = request.Color;
                _car.Company = request.Company;
                _car.ParkingLotId = request.ParkingLotId;

                await _cars.Update(_car).ConfigureAwait(false);

            }
        }
    }
}
