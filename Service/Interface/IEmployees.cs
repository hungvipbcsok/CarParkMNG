using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IEmployees
    {
        public Task CreateEmployee(Employee request);
        public Task<List<Employee>> GetAllEmployee();
        public Task<Employee> GetEmployeeById(int Id);
        public Task UpdateEmployee(int Id, Employee request);
        public Task DeleteEmployee(int Id);
    }
}
