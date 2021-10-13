using Kwanso.Api.Models;
using Kwanso.Api.ViewModels;
using System.Collections.Generic;

namespace Kwanso.Api.Interfaces
{
    public interface ITasksService
    {
        Tasks AddTask(Tasks Task);
        List<TaskListViewModel> GetAll();
        void BulkDelete(string ids);
    }
}
