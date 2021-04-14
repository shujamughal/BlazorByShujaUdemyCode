using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_BlazorServer.Models
{
    public class EmployeeService : IEmployee
    {
        List<Employee> employees;
        public string Object_ID { get; set; }
        public EmployeeService()
        {
            Object_ID = Guid.NewGuid().ToString();
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
