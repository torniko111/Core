﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAllEmployee();
        Employee CreateNew(Employee employee);
        Employee Delete(int id);
        Employee Update(Employee employee);

    }
}
