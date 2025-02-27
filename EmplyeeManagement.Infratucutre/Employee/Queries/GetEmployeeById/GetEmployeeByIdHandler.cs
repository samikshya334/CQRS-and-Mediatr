using AutoMapper;
using EmployeeMangemen.Domain.Repository;
using EmplyeeManagement.Application.Employee.Queries.GetEmployee;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeManagement.Application.Employee.Queries.GetEmployeeById
{
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, EmployeeVM>

    {
        private readonly IEmployeeRepository _employeeRepository; 
        private readonly IMapper _mapper;
        public GetEmployeeByIdHandler(IEmployeeRepository employeeRepository,IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        public  async Task<EmployeeVM> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
          var employee= await  _employeeRepository.GetByIdAsync(request.EmployeeID);
             return _mapper.Map<EmployeeVM>(employee);
        }
    }
}
