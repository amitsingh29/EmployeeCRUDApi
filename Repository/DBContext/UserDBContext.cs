//-----------------------------------------------------------------------
// <copyright file="UserDBContext.cs" company="BridgeLabz">
//     Copyright © 2020
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace Repository.DBContext
{
    using Microsoft.EntityFrameworkCore;
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class UserDBContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDBContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the employees.
        /// </summary>
        /// <value>
        /// The employees.
        /// </value>
        public DbSet<EmployeeModel> Employees
        {
            get; set;
        }
    }
}
