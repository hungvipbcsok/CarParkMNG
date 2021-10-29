using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IGenericService<T>
    {
        /*IQueryable<T> GetAll();

        T GetById(int id);

        List<T> Insert(T item);

        List<T> Delete(int id);*/

        //Add data to SQl Server
        public Task Create(T entity);

        //Get all of data from SQl Server
        public Task<List<T>> GetAll();

        //Get data by Id from SQl Server
        public Task<T> GetId(int Id);

        // Update data to SQl Server
        public Task Update(T entity);

        // Delete data to SQl Server
        public Task Delete(T entity);
    }
}
