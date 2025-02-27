using EmplyeeManagement.Application.Employee.Queries.GetEmployee;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeManagement.Application.Employee.Queries.GetEmployeeById
{
    public class GetEmployeeByIdQuery:IRequest<EmployeeVM>
    {
        public int EmployeeID { get; set; }
    }
}
