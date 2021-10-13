using Kwanso.Api.Authentication;
using Kwanso.Api.Interfaces;
using Kwanso.Api.Models;
using Kwanso.Api.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace Kwanso.Api.Controllers
{
    [Authorize]
    [ApiController]
    public class TaskController : Controller
    {
        private readonly ITasksService _tasksService;

        public TaskController(ITasksService tasksService)
        {
            _tasksService = tasksService;
        }

        // GET: TaskController/create-task
        [HttpPost]
        [Route("create-task")]
        public IActionResult AddTask(TaskViewModel taskname)
        {
            try
            {
                Tasks result = _tasksService.AddTask(new Tasks {Name = taskname.Name, UsersId = User.Claims.FirstOrDefault().Value, IsDelete = false });
                return Json("task:" + new { Id = result.Id, name = result.Name });
            }
            catch (Exception)
            {
                return Ok(new Response { Status = "Error", Message = "Task creation failed! Please check Task details and try again." });
            }
        }


        [HttpGet]
        [Route("list-tasks")]
        public IActionResult TasksList()
        {
            try
            {
                //return Ok("tasks:" + JsonConvert.SerializeObject(_tasksService.GetAll(), Formatting.Indented));
                return Ok(JsonConvert.SerializeObject(_tasksService.GetAll()));
            }
            catch (Exception)
            {
                return Json(new Response { Status = "Error", Message = "Task creation failed! Please check Task details and try again." });
            }
        }

        [HttpPost]
        [Route("bulk-delete")]
        public IActionResult BulkDelete(string ids)
        {
            try
            {
                if (!string.IsNullOrEmpty(ids))
                {
                    _tasksService.BulkDelete(ids);
                }
                
            }
            catch (Exception)
            {
                return Ok(new Response { Status = "Error", Message = "Task creation failed! Please check Task details and try again." });
            }
            return Ok();
        }
    }
}
