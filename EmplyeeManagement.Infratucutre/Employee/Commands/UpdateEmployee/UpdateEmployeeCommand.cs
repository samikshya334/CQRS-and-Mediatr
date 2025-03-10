﻿using EmplyeeManagement.Application.Employee.Queries.GetEmployee;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeManagement.Application.Employee.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommand:IRequest<int>
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeDescription { get; set; }
        public string EmployeePhoneNumber { get; set; }
        public string EmployeeAddress { get; set; }
    }
}
