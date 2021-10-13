using Kwanso.Api.Models;
using Kwanso.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kwanso.Api.Interfaces
{
    public interface ITasksService
    {
        Tasks AddTask(Tasks Task);
        List<TaskListViewModel> GetAll();
        void BulkDelete(string ids);
    }
}
