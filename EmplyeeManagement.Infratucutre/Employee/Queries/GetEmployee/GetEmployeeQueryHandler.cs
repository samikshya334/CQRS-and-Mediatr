using AutoMapper;
using EmployeeMangemen.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeManagement.Application.Employee.Queries.GetEmployee
{
    public class GetEmployeeQueryHandler : IRequestHandler<GetEmployeeQuery, List<EmployeeVM>>
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public GetEmployeeQueryHandler(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository=employeeRepository;
            _mapper= mapper;
        }
        public async Task<List<EmployeeVM>> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            var employees = await _employeeRepository.GetAllEmployeesAsync();
            //var employeeList = employees.Select(x=>new EmployeeVM { EmployeeID=x.EmployeeID,EmployeeName=x.EmployeeName
            //,EmployeeDescription=x.EmployeeDescription,EmployeeAddress=x.EmployeeAddress,EmployeePhoneNumber=x.EmployeePhoneNumber}).ToList();
            var employeeList= _mapper.Map<List<EmployeeVM>>(employees); 
            return employeeList;

        }
    }
}
