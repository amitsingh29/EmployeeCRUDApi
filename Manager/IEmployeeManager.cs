//-----------------------------------------------------------------------
// <copyright file="IEmployeeManager.cs" company="BridgeLabz">
//     Copyright © 2020
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace Manager
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IEmployeeManager
    {
        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>employee model</returns>
        EmployeeModel GetEmployee(int id);

        /// <summary>
        /// Gets all employees.
        /// </summary>
        /// <returns>employee model</returns>
        IEnumerable<EmployeeModel> GetAllEmployees();

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>task integer</returns>
        Task<int> AddEmployee(EmployeeModel employee);

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employeeChanges">The employee changes.</param>
        /// <returns>task integer</returns>
        Task<int> UpdateEmployee(EmployeeModel employeeChanges);

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>employee model</returns>
        EmployeeModel DeleteEmployee(int id);

        bool LoginEmployee(string email, string password);
    }
}
