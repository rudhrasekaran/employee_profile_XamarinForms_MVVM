using EmployeeProfile.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProfile.Interface
{
    public interface IEmployeeDB
    {
        Task<List<Employee>> GetEmployeeData();
        Task<Employee> GetEmployeeById(int id);
        Task<int> SaveEmployeeData(Employee employee);
        Task<int> DeleteEmployeeData(int id);
    }
}
