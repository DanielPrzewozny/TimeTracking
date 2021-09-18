﻿using System;
using System.Collections.Generic;
using System.Text;
using TimeTrackingSystem.Application.ViewModels;
using TimeTrackingSystem.Application.ViewModels.Employee;

namespace TimeTrackingSystem.Application.Interfaces
{
    public interface IEmployeeService
    {
        ListOfEmployeesViewModel GetAllEmployees(int pageSize, int pageNo, string searchBy);
        EmployeeDetailsViewModel GetEmployeeDetails(int accountId);
        NewEmployeeViewModel EmployeeForEdit(int id);
        //void UpdateEmployee(NewEmployeeViewModel model);
    }
}
