using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeManagement.Application.Employee.Commands.DeleteEmployee
{
    public class DeleteEmployeeCommand:IRequest<int>
    {
        public int EmployeeId { get; set; }
    }
}
