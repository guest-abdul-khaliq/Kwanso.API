using Kwanso.Api.Interfaces;
using Kwanso.Api.Models;
using Kwanso.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kwanso.Api.Services
{
    public class TasksService : ITasksService
    {
        private readonly ApplicationDbContext _db;
        public TasksService(ApplicationDbContext db)
        {
            _db = db;
        }

        public Tasks AddTask(Tasks tasks)
        {
            try
            {
                var result = _db.tasks.Add(tasks);
                _db.SaveChanges();
                return new Tasks { Id = result.Entity.Id, Name = result.Entity.Name };
            }
            catch (Exception ex)
            {

            }
            return new Tasks();
        }

        public List<TaskListViewModel> GetAll()
        {
            try
            {
                return _db.tasks.Where(x=> x.IsDelete != true).Select(x => new TaskListViewModel { Id = x.Id, Name = x.Name }).ToList();
            }
            catch (Exception ex)
            {

            }
            return new List<TaskListViewModel>();
        }

        public void BulkDelete(string ids)
        {
            try
            {
                //var result = _db.tasks.FromSqlRaw("EXEC BulkDeleteTasks_sp @Ids", ids);
                string[] values = ids.Split(',');
                foreach (var item in values)
                {
                    Tasks task = _db.tasks.Where(x => x.Id == long.Parse(item.Trim())).FirstOrDefault();
                    task.IsDelete = true;
                    _db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
