using Model.Context;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implemention
{
    public class GenericImplemention<TEntity> : IGenericService<TEntity> where TEntity : class
    {

        private readonly CarBookingContext _dbContext;

        public GenericImplemention(CarBookingContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(TEntity entity)
        {
            //Add data to SQl Server
            await _dbContext.Set<TEntity>().AddAsync(entity);
            _dbContext.SaveChanges();
        }

        public async Task<List<TEntity>> GetAll()
        {
            //Get all of data from SQl Server
            return _dbContext.Set<TEntity>().ToList();

        }

        public async Task<TEntity> GetId(int Id)
        {
            //Get data by Id from SQl Server
            return await _dbContext.Set<TEntity>().FindAsync(Id);

        }

        public async Task Update(TEntity entity)
        {
            // Update data to SQl Server
            _dbContext.Set<TEntity>().Update(entity);
            _dbContext.SaveChanges();
        }

        public async Task Delete(TEntity entity)
        {
            // Delete data to SQl Server
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }

    }
}
