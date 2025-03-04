using EmployeeMangemen.Domain.Entity;
using EmployeeMangemen.Domain.Repository;
using EmplyeeManagement.Infrastucuture.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeManagement.Infrastucuture.Repository
{
    public class EmployeeRepository : IEmployeeRepository
        
    {
        private readonly EmployeeDbContext _employeeDbContext;
        public EmployeeRepository(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
            
        }
        public async Task<Employee> CreateEmployeeAsync(Employee employee)
        {
            await _employeeDbContext.Employees.AddAsync(employee);
            await _employeeDbContext.SaveChangesAsync();
            return employee;
        }

        public async Task<int> DeleteAsyn(int employeeId)
        {
            return await _employeeDbContext.Employees.Where(model=>model.EmployeeID == employeeId).ExecuteDeleteAsync();
        }

   
        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await  _employeeDbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            return await _employeeDbContext.Employees.AsNoTracking().FirstOrDefaultAsync(b => b.EmployeeID==id);
        }

        public async Task<int> UpdateAsync(int employeeID, Employee updateEntity)
        {
            return await _employeeDbContext.Employees.Where(model => model.EmployeeID==employeeID).ExecuteUpdateAsync(setters => setters.
            SetProperty(m => m.EmployeeID, updateEntity.EmployeeID).SetProperty(m => m.EmployeeName, updateEntity.EmployeeName)
            .SetProperty(m => m.EmployeeAddress, updateEntity.EmployeeAddress).SetProperty(m => m.EmployeePhoneNumber, updateEntity.EmployeePhoneNumber));
        }
    }
}
