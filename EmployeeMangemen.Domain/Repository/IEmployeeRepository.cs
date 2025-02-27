using EmployeeMangemen.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangemen.Domain.Repository
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllEmployeesAsync();
        Task<Employee> GetByIdAsync(int id);
        Task<Employee> CreateEmployeeAsync(Employee employee);
        Task<int> UpdateEmployeeAsync(int id , Employee employee);
        Task<int> DeleteEmployeeAsync(int id);

    }
}
