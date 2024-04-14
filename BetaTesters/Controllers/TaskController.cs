using BetaTesters.Core.Contracts;
using BetaTesters.Core.Models.Task;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BetaTesters.Controllers
{
    public class TaskController : BaseController
    {
        private readonly ITaskService taskService;
        private readonly IApplicationUserService applicationUserService;

        public TaskController(ITaskService _taskService, 
            IApplicationUserService _applicationUserService)
        {
            taskService = _taskService;
            applicationUserService = _applicationUserService;

        }

        [HttpGet]
        public async Task<IActionResult> All(string id, [FromQuery] AllTasksQueryModel query)
        {
            var user = await applicationUserService.GetApplicationUserByIdAsync(User.Id());

            if(user.BetaProgramId.ToString() != id)
            {
                return Unauthorized();
            }

            var model = await taskService.AllByProgramIdAsync(
                id,
                query.Category,
                query.TaskSorting,
                query.CurrentPage,
                AllTasksQueryModel.TasksPerPage);

            query.TotalTasksCount = model.TotalTasksCount;
            query.Tasks = model.Tasks;
            query.Categories = await taskService.AllCategoriesNameAsync();
            query.BetaProgramId = id;

            if(query.TotalTasksCount == 0)
            {
                ViewBag.TaskCountMessage = "There are no tasks in this program yet!";
            }

            return View(query);
        }
    }
}
