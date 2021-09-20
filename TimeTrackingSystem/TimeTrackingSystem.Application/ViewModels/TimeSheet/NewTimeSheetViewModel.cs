﻿using AutoMapper;
using FluentValidation;
using System;
using TimeTrackingSystem.Application.Mapping;

namespace TimeTrackingSystem.Application.ViewModels.TimeSheet
{
    public class NewTimeSheetViewModel : IMapFrom<Domain.Model.TimeSheet>
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public int ActivityId { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time_from { get; set; }
        public DateTime Time_to { get; set; }
        public string Comments { get; set; }
        public DateTime Date_submitted { get; set; }
        public void Mapping(Profile profile)
        {
            //<source, destination>
            profile.CreateMap<NewTimeSheetViewModel, Domain.Model.TimeSheet>().ReverseMap();
        }
    }
    public class NewTimeSheetValidation : AbstractValidator<NewTimeSheetViewModel>
    {
        public NewTimeSheetValidation()
        {
            RuleFor(x => x.Comments).Length(3, 50);
        }
    }
}
