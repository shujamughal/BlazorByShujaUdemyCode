using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DI_BlazorWebAssembly.Models;
using Microsoft.AspNetCore.Components;

namespace DI_BlazorWebAssembly.Pages
{
    public partial class EmployeeComponent
    {
        [Inject]
        IEmployee myService { get; set; }
        List<Employee> list;
        protected override void OnInitialized()
        {
            base.OnInitialized();
            list = myService.GetAllEmployee();
        }
    }
}
