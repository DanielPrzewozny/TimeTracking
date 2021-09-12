﻿using System;
using Microsoft.AspNetCore.Mvc;
using TimeTrackingSystem.Application.Interfaces;
using TimeTrackingSystem.Application.ViewModels.Employee;

namespace TimeTrackingSystem.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var model = _employeeService.GetAllEmployees(2, 1, "");
            return View(model);
        }
        
        [HttpPost]
        public IActionResult Index(int pageSize, int? pageNo, string searchBy)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }

            if (searchBy is null)
            {
                searchBy = String.Empty;
            }
            var model = _employeeService.GetAllEmployees(pageSize, pageNo.Value, searchBy);
            return View(model);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View(new NewEmployeeViewModel());
        }

        [HttpPost]
        public IActionResult AddEmployee(NewEmployeeViewModel model)
        {
            var id = _employeeService.AddEmployee(model);
            return RedirectToAction("ViewEmployee", new { accountId = id });
        }

        [HttpGet]
        public IActionResult EditEmployee(int id)
        {
            var employee = _employeeService.EmployeeForEdit(id);
            return View(employee);
        }
        [HttpPost]
        public IActionResult EditEmployee(NewEmployeeViewModel model)
        {
            _employeeService.UpdateEmployee(model);
            return RedirectToAction("ViewEmployee", new { accountId = model.Id });
            //View(model);
            //RedirectToAction("ViewEmployee", new { accountId = id });
        }

        [HttpGet]
        public IActionResult RemoveEmployee()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult RemoveEmployee(Account model)
        //{
        //    var id = _employeeService.RemoveEmployee(model);
        //    return View();
        //}

        public IActionResult ViewEmployee(int accountId)
        {
            var employeeModel = _employeeService.GetEmployeeDetails(accountId);
            return View(employeeModel);
        }
    }
}