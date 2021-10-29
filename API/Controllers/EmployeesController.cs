using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Context;
using Model.Entity;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    /*public class EmployeesController : GenericController<Employee>
    {
        public EmployeesController(IGenericService<Employee> genericService) : base(genericService)
        {

        }


    }*/
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployees _employeeService;

        public EmployeesController(IEmployees employeeService)
        {
            _employeeService = employeeService;
        }


        [HttpGet("Get-Employee-ByID")]
        public async Task<IActionResult> GetEmpoyeeById(int Id)
        {
            var _employee = await _employeeService.GetEmployeeById(Id);

            return Ok(_employee);
        }

        [HttpGet("Get-All-Employee")]
        public async Task<IActionResult> GetAllEmployee()
        {
            var _allEmployee = await _employeeService.GetAllEmployee().ConfigureAwait(false);

            return Ok(_allEmployee);
        }

        [HttpPost("Add-Employee")]
        public async Task<IActionResult> CreateEmployee(Employee employee)
        {
            await _employeeService.CreateEmployee(employee).ConfigureAwait(false);
            return Ok();
        }

        [HttpPut("Update-Employee-ByID")]
        public async Task<IActionResult> UpdateEmployee(int Id, Employee employee)
        {
            await _employeeService.UpdateEmployee(Id, employee).ConfigureAwait(false);

            return Ok();
        }

        [HttpDelete("Delete-Employee-ByID")]
        public async Task<IActionResult> DeleteEmployee(int Id)
        {
            await _employeeService.DeleteEmployee(Id).ConfigureAwait(false);

            return Ok();
        }
    }
}
