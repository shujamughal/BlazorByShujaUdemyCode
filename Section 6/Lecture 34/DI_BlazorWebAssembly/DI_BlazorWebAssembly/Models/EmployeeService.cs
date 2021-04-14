using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_BlazorWebAssembly.Models
{
    public class EmployeeService : IEmployee
    {
        List<Employee> employees;

        public EmployeeService()
        {
            employees = new List<Employee> {
            new Employee {Name="John", Department="IT" },
            new Employee {Name="Doe", Department="Sales" },
            };
        }
        public List<Employee> GetAllEmployee()
        {
            return employees;
        }
    }
}
