using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeManagement.Application.Employee.Queries.GetEmployee
{
    public class GetEmployeeQuery:IRequest<List <EmployeeVM>>
    {
    }
}
