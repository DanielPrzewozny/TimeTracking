﻿using AutoMapper;
using FluentValidation;
using TimeTrackingSystem.Application.Mapping;
using TimeTrackingSystem.Domain.Model;

namespace TimeTrackingSystem.Application.ViewModels.Employee
{
    public class NewEmployeeViewModel : IMapFrom<ApplicationUser>
    {
        public string Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public bool IsEnable { get; set; }

        public void Mapping(Profile profile)
        {
            //<source, destination>
            profile.CreateMap<NewEmployeeViewModel, ApplicationUser>().ReverseMap();
        }
    }
    public class NewEmployeeValidation : AbstractValidator<NewEmployeeViewModel>
    {
        public NewEmployeeValidation()
        {
            RuleFor(x => x.First_Name).Length(2, 15);
            RuleFor(x => x.Last_Name).Length(2, 15);
            RuleFor(x => x.Email).EmailAddress();
        }
    }
}
