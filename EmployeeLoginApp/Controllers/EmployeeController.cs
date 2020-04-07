using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager;
using Microsoft.AspNetCore.Mvc;
using Model;
using Serilog;

namespace EmployeeLoginApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// The manager
        /// </summary>
        public readonly IEmployeeManager manager;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        /// <param name="manager">The manager.</param>
        public EmployeeController(IEmployeeManager manager)
        {
            this.manager = manager;
        }

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        [Route("AddEmployee")]
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Model.EmployeeModel employee)
        {
            var result = await this.manager.AddEmployee(employee);
            if (result == 1)
            {
                return this.Ok(employee);
            }
            else
            {
                Log.Error("This is a Bad Request");
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Gets all employees.
        /// </summary>
        /// <returns></returns>
        [Route("GetAllEmployee")]
        [HttpGet]
        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            return this.manager.GetAllEmployees();
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employeeChanges">The employee changes.</param>
        /// <returns></returns>
        [Route("UpdateEmployee")]
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(EmployeeModel employeeChanges)
        {
            var result = await this.manager.UpdateEmployee(employeeChanges);
            if (result == 1)
            {
                return this.Ok(employeeChanges);
            }
            else
            {
                Log.Error("This is a Bad Request");
                return this.BadRequest();
            }
        }

        [Route("LoginEmployee")]
        [HttpPost]
        public IActionResult LoginEmployee(string email, string password)
        {
            var result = this.manager.LoginEmployee(email, password);
            if (result == true)
            {
                return this.Ok(email);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteEmployee")]
        public EmployeeModel DeleteEmployee(int id)
        {
            Log.Information("Employee Deleted");
            return this.manager.DeleteEmployee(id);
        }

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [Route("GetEmployee")]
        [HttpGet]
        public EmployeeModel GetEmployee(int id)
        {
            return this.manager.GetEmployee(id);
        }
    }
}

