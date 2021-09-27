﻿using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TimeTrackingSystem.Application.Interfaces;
using TimeTrackingSystem.Application.Services;
using TimeTrackingSystem.Application.ViewModels.TimeSheet;
using TimeTrackingSystem.Domain.Model;

namespace TimeTrackingSystem.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<ITimeSheetService, TimeSheetService>();
            services.AddTransient<IProjectService, ProjectService>();
            services.AddTransient<IActivityService, ActivityService>();
            services.AddTransient<ILeavesService, LeavesService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
