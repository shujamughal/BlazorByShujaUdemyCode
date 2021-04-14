using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_BlazorWebAssembly.Models
{
    interface IEmployee
    {
        public List<Employee> GetAllEmployee();
    }
}
