using EmployeeMangemen.Domain.Entity; // This should contain your Employee class
using EmplyeeManagement.Application.Common.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeManagement.Application.Employee.Queries.GetEmployee
{
    public class EmployeeVM : IMapFrom<EmployeeMangemen.Domain.Entity.Employee>
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeDescription { get; set; }
        public string EmployeePhoneNumber { get; set; }
        public string EmployeeAddress { get; set; }
    }
}