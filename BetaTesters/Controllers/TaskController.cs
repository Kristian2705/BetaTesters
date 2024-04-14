using BetaTesters.Core.Contracts;
using BetaTesters.Core.Models.Task;
using static BetaTesters.Infrastructure.Constants.RoleConstants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using BetaTesters.Infrastructure.Data.Enums;

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

            if (user.BetaProgramId.ToString() != id)
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

            if (query.TotalTasksCount == 0)
            {
                ViewBag.TaskCountMessage = "There are no tasks in this program yet!";
            }

            return View(query);
        }

        [HttpGet]
        [Authorize(Roles = $"{ModeratorRole},{OwnerRole}")]
        public async Task<IActionResult> Add(string programId)
        {
            var model = new TaskFormModel()
            {
                ProgramId = programId,
                Categories = await taskService.AllCategoriesAsync()
            };

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = $"{ModeratorRole},{OwnerRole}")]
        public async Task<IActionResult> Add(TaskFormModel model)
        {
            if (await taskService.CategoryExistsAsync(model.CategoryId) == false)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category does not exits");
            }

            if(model.ProgramId == null)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Beta program does not exits");
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await taskService.AllCategoriesAsync();

                return View(model);
            }

            try
            {
                if (User.IsInRole(OwnerRole))
                {
                    model.Approval = Approval.Accepted;
                    model.TaskState = TaskState.Available;
                    await taskService.CreateAsync(model, User.Id(), DateTime.Now);
                }
                else
                {
                    model.Approval = Approval.ToBeReviewed;
                    model.TaskState = TaskState.ToBeApproved;
                    await taskService.CreateAsync(model, User.Id(), null);
                }
            }
            catch (Exception)
            {
                GeneralError();
            }

            return RedirectToAction(nameof(BetaProgramController.Mine), "BetaProgram");
        }

        //[HttpGet]
        //[Authorize(Roles = OwnerRole)]
        //public async Task<IActionResult> VisitWaitlist()
        //{

        //}
    }
}
