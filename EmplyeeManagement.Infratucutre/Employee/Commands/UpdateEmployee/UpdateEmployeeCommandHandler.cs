
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using EmployeeMangemen.Domain.Repository;
using EmplyeeManagement.Application.Employee.Commands.UpdateEmployee;

namespace EmployeeManagement.Application.Employee.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, int>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public UpdateEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<int> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var updateEntity = new EmployeeMangemen.Domain.Entity.Employee()
            {
                EmployeeID = request.EmployeeID,
                EmployeeName = request.EmployeeName,
                EmployeeDescription = request.EmployeeDescription,
                EmployeeAddress = request.EmployeeAddress,
            };

            return await _employeeRepository.UpdateAsync(request.EmployeeID, updateEntity);
        }
    }
}