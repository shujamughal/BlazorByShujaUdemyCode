﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_BlazorServer.Models
{
    interface IEmployee
    {
        public List<Employee> GetAllEmployee();
    }
}
