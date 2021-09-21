﻿using System.Linq;
using TimeTrackingSystem.Domain.Model;

namespace TimeTrackingSystem.Domain.Interfaces
{
    public interface IActivityRepository
    {
        void Delete(int activityId);
        int Add(Activity activity);
        Activity Get(int activityId);
        IQueryable<Activity> GetByProjectId(int projectId);
        IQueryable<ActivityProject> GetAll();
        IQueryable<ActivityProject> GetAll(int id);
        void Update(Activity activity);
    }
}
