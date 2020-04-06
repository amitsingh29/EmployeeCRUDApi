//-----------------------------------------------------------------------
// <copyright file="EmployeeModel.cs" company="BridgeLabz">
//     Copyright © 2020
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    public class EmployeeModel
    {
        /// <summary>
        /// The employee identifier
        /// </summary>
        private int employeeID;

        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The email identifier
        /// </summary>
        private string emailID;

        /// <summary>
        /// The password
        /// </summary>
        private string password;

        /// <summary>
        /// The mobile
        /// </summary>
        private string mobile;

        /// <summary>
        /// The address
        /// </summary>
        private string address;

        /// <summary>
        /// Gets or sets the emp identifier.
        /// </summary>
        /// <value>
        /// The employee identifier.
        /// </value>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int EmpID
        {
            get
            {
                return this.employeeID;
            }

            set
            {
                this.employeeID = value;
            }
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email
        {
            get
            {
                return this.emailID;
            }

            set
            {
                this.emailID = value;
            }
        }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                this.password = value;
            }
        }

        /// <summary>
        /// Gets or sets the mobile.
        /// </summary>
        /// <value>
        /// The mobile.
        /// </value>
        public string Mobile
        {
            get
            {
                return this.mobile;
            }

            set
            {
                this.mobile = value;
            }
        }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                this.address = value;
            }
        }
    }
}
