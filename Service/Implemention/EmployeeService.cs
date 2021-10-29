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
    public class EmployeeService : IEmployees
    {
        /*private CarBookingContext _dbContext;
        private readonly IGenericService<Employee> _genericService;

        public EmployeeService(CarBookingContext dbContext, IGenericService<Employee> genericService)
        {
            _dbContext = dbContext;
            _genericService = genericService;
        }*/

        /*public List<Employee> Delete(int id)
        {
            *//*_employees.RemoveAll(x=>x.Id == id);
            return _employees;*//*
            _dbContext.Employees
                .RemoveRange(_dbContext.Employees.Where(x => x.Id == id).FirstOrDefault());
            _dbContext.SaveChanges();
            return _dbContext.Employees.ToList();
        }

        public IQueryable<Employee> GetAll()
        {
            //return _employees;
            return _dbContext.Employees;
        }

        public Employee GetById(int id)
        {
            //return _employees.Where(x => x.Id == id).SingleOrDefault();
            return _dbContext.Employees.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Employee> Insert(Employee item)
        {
            *//*_employees.Add(item);
            return _employees;*//*
            _dbContext.Employees.Add(item);
            _dbContext.SaveChanges();
            return _dbContext.Employees.ToList();
        }*/

        private readonly IGenericService<Employee> _employeeRespository;

        public EmployeeService(IGenericService<Employee> employeeRespository)
        {
            _employeeRespository = employeeRespository;
        }

        public async Task CreateEmployee(Employee request)
        {
            var _employee = new Employee()
            {
                FullName = request.FullName,
                DOB = request.DOB,
                Sex = request.Sex,
                Address = request.Address,
                Phone = request.Phone,
                Email = request.Email,
                Account = request.Account,
                Password = request.Password,
                Department = request.Department
            };

            await _employeeRespository.Create(_employee).ConfigureAwait(false);

        }


        public async Task<List<Employee>> GetAllEmployee()
        {

            return await _employeeRespository.GetAll().ConfigureAwait(false);

        }


        public async Task<Employee> GetEmployeeById(int Id)
        {

            return await _employeeRespository.GetId(Id);

        }


        public async Task UpdateEmployee(int Id, Employee request)
        {
            var _employee = await _employeeRespository.GetId(Id);

            if (_employee != null)
            {
                _employee.FullName = request.FullName;
                _employee.DOB = request.DOB;
                _employee.Sex = request.Sex;
                _employee.Address = request.Address;
                _employee.Phone = request.Phone;
                _employee.Email = request.Email;
                _employee.Account = request.Account;
                _employee.Password = request.Password;
                _employee.Department = request.Department;


                await _employeeRespository.Update(_employee).ConfigureAwait(false);

            }
        }


        public async Task DeleteEmployee(int Id)
        {
            var _employee = await _employeeRespository.GetId(Id);

            await _employeeRespository.Delete(_employee).ConfigureAwait(false);
        }
    }
}
