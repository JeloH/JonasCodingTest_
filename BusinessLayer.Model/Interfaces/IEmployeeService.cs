﻿using System.Collections.Generic;
using BusinessLayer.Model.Models;

namespace BusinessLayer.Model.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeInfo> GetAllEmployees();
        EmployeeInfo GetByCodeEmployee(string employeeCode);
    }
}
