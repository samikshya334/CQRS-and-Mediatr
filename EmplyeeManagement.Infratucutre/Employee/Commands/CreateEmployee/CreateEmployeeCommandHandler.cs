using AutoMapper;
using EmployeeMangemen.Domain.Repository;
using EmployeeMangemen.Domain.Entity; // Add this import to access the Employee entity
using EmplyeeManagement.Application.Employee.Queries.GetEmployee;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeManagement.Application.Employee.Commands.CreateEmployee
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, EmployeeVM>
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public CreateEmployeeCommandHandler(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<EmployeeVM> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employeeEntity = new EmployeeMangemen.Domain.Entity.Employee()
            {
                EmployeeName = request.EmployeeName,
                EmployeeDescription = request.EmployeeDescription,
                EmployeeAddress = request.EmployeeAddress,
                EmployeePhoneNumber = request.EmployeePhoneNumber
            };

            var Result = await _employeeRepository.CreateEmployeeAsync(employeeEntity);
            return _mapper.Map<EmployeeVM>(Result);
        }
    }
}