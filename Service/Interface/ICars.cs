using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ICars
    {
        public Task CreateCar(Car request);
        public Task DeleteCar(string lincensplate);
        public Task<List<Car>> GetAllCar();
        public Task<Car> GetCarById(string lincensplate);
        public Task UpdateCar(string lincensplate, Car request);
    }
}
