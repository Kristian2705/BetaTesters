﻿using BetaTesters.Core.Contracts;
using BetaTesters.Core.Models.Task;
using static BetaTesters.Infrastructure.Constants.RoleConstants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using BetaTesters.Infrastructure.Data.Enums;
using BetaTesters.Core.Services;
using BetaTesters.Core.Models.CandidateApplication;

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
            if(id == null)
            {
                return BadRequest();
            }

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
            if(programId == null)
            {
                return BadRequest();
            }

            var user = await applicationUserService.GetApplicationUserByIdAsync(User.Id());

            if(user.BetaProgramId.ToString() != programId)
            {
                return Unauthorized();
            }

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

            if (model.ProgramId == null)
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

        [HttpGet]
        [Authorize(Roles = $"{ModeratorRole},{OwnerRole}")]
        public async Task<IActionResult> Edit(string taskId)
        {
            if(taskId == null)
            {
                return BadRequest();
            }

            if(await taskService.ExistsAsync(taskId) == false)
            {
                return BadRequest();
            }

            var task = await taskService.GetTaskFormModelByIdAsync(taskId);

            var user = await applicationUserService.GetApplicationUserByIdAsync(User.Id());

            if(user.BetaProgramId != Guid.Parse(task.ProgramId))
            {
                return Unauthorized();
            }

            if(task.TaskState != TaskState.Available || task.Approval != Approval.Accepted)
            {
                return BadRequest();
            }

            if (User.IsInRole(ModeratorRole))
            {
                if(task.CreatorId.ToLower() != User.Id())
                {
                    return Unauthorized();
                }
            }

            return View(task);
        }

        [HttpPost]
        [Authorize(Roles = $"{ModeratorRole},{OwnerRole}")]
        public async Task<IActionResult> Edit(string taskId, TaskFormModel model)
        {
            if (taskId == null)
            {
                return BadRequest();
            }

            if (await taskService.ExistsAsync(taskId) == false)
            {
                return BadRequest();
            }

            var task = await taskService.GetTaskFormModelByIdAsync(taskId);

            var user = await applicationUserService.GetApplicationUserByIdAsync(User.Id());

            if (user.BetaProgramId != Guid.Parse(task.ProgramId))
            {
                return Unauthorized();
            }

            if (task.TaskState != TaskState.Available || task.Approval != Approval.Accepted)
            {
                return BadRequest();
            }

            if (User.IsInRole(ModeratorRole))
            {
                if (task.CreatorId.ToLower() != User.Id())
                {
                    return Unauthorized();
                }
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await taskService.AllCategoriesAsync();
                return View(model);
            }

            await taskService.EditAsync(taskId, model);

            return RedirectToAction(nameof(BetaProgramController.Mine), "BetaProgram");
        }

        [HttpGet]
        [Authorize(Roles = OwnerRole)]
        public async Task<IActionResult> VisitWaitlist(string programId)
        {
            if(programId == null)
            {
                return BadRequest();
            }

            var user = await applicationUserService.GetApplicationUserByIdAsync(User.Id());

            if (user.BetaProgramId.ToString() != programId)
            {
                return Unauthorized();
            }

            var tasks = await taskService.TaskWaitListByProgramIdAsync(programId);

            return View(tasks);
        }

        [HttpGet]
        [Authorize(Roles = OwnerRole)]
        public async Task<IActionResult> Approve(string taskId)
        {
            if(taskId == null)
            {
                return BadRequest();
            }

            var task = await taskService.TaskInspectViewModelByIdAsync(taskId);

            var user = await applicationUserService.GetApplicationUserByIdAsync(User.Id());

            if(user.BetaProgramId != task.BetaProgramId)
            {
                return Unauthorized();
            }

            if (task.Approval != Approval.ToBeReviewed)
            {
                return BadRequest();
            }

            return View(task);
        }

        [HttpPost]
        [Authorize(Roles = OwnerRole)]
        public async Task<IActionResult> Approve(string taskId, TaskInspectViewModel model)
        {
            if (model == null || taskId == null)
            {
                return BadRequest();
            }

            await taskService.ApproveTaskAsync(taskId);

            return RedirectToAction(nameof(BetaProgramController.Mine), "BetaProgram");
        }

        [HttpGet]
        [Authorize(Roles = OwnerRole)]
        public async Task<IActionResult> Reject(string taskId)
        {
            if (taskId == null)
            {
                return BadRequest();
            }

            var task = await taskService.TaskInspectViewModelByIdAsync(taskId);

            var user = await applicationUserService.GetApplicationUserByIdAsync(User.Id());

            if (user.BetaProgramId != task.BetaProgramId)
            {
                return Unauthorized();
            }

            if (task.Approval != Approval.ToBeReviewed)
            {
                return BadRequest();
            }

            return View(task);
        }

        [HttpPost]
        [Authorize(Roles = OwnerRole)]
        public async Task<IActionResult> Reject(string taskId, TaskInspectViewModel model)
        {
            if (model == null || taskId == null)
            {
                return BadRequest();
            }

            await taskService.RejectTaskAsync(taskId);

            return RedirectToAction(nameof(BetaProgramController.Mine), "BetaProgram");
        }

        [HttpGet]
        [Authorize(Roles = DefaultUserRole)]
        public async Task<IActionResult> Take(string taskId)
        {
            if(taskId == null)
            {
                return BadRequest();
            }

            var task = await taskService.TaskInspectViewModelByIdAsync(taskId);

            var user = await applicationUserService.GetApplicationUserByIdAsync(User.Id());

            if (user.BetaProgramId != task.BetaProgramId)
            {
                return Unauthorized();
            }

            if (task.Approval != Approval.Accepted && task.State != TaskState.Available)
            {
                return BadRequest();
            }

            return View(task);
        }

        [HttpPost]
        [Authorize(Roles = DefaultUserRole)]
        public async Task<IActionResult> Take(string taskId, TaskInspectViewModel model)
        {
            if (model == null || taskId == null)
            {
                return BadRequest();
            }

            await taskService.TakeTaskAsync(taskId, User.Id());

            return RedirectToAction(nameof(BetaProgramController.Mine), "BetaProgram");
        }

        [HttpGet]
        [Authorize(Roles = DefaultUserRole)]
        public async Task<IActionResult> Complete(string taskId)
        {
            if (taskId == null)
            {
                return BadRequest();
            }

            var task = await taskService.TaskInspectViewModelByIdAsync(taskId);

            if (task.Approval != Approval.Accepted && task.State != TaskState.InProgress)
            {
                return BadRequest();
            }

            var userId = User.Id();

            if (task.ContractorId.ToLower() != userId)
            {
                return Unauthorized();
            }

            return View(task);
        }

        [HttpPost]
        [Authorize(Roles = DefaultUserRole)]
        public async Task<IActionResult> Complete(string taskId, TaskInspectViewModel model)
        {
            if (model == null || taskId == null)
            {
                return BadRequest();
            }

            await taskService.CompleteTaskAsync(taskId);

            return RedirectToAction(nameof(BetaProgramController.Mine), "BetaProgram");
        }

        [HttpGet]
        [Authorize(Roles = DefaultUserRole)]
        public async Task<IActionResult> Mine(string programId)
        {
            if(programId == null)
            {
                return BadRequest();
            }

            var user = await applicationUserService.GetApplicationUserByIdAsync(User.Id());

            if(user.BetaProgramId.ToString() != programId)
            {
                return Unauthorized();
            }

            var myTasks = await taskService.GetTasksByUserIdAndProgramId(user.Id.ToString(), programId);

            return View(myTasks);
        }

        [HttpGet]
        [Authorize(Roles = DefaultUserRole)]
        public async Task<IActionResult> Forfeit(string taskId)
        {
            if(taskId == null)
            {
                return BadRequest();
            }

            var task = await taskService.TaskInspectViewModelByIdAsync(taskId);

            if (task.Approval != Approval.Accepted && task.State != TaskState.InProgress)
            {
                return BadRequest();
            }

            var userId = User.Id();

            if (task.ContractorId.ToLower() != userId)
            {
                return Unauthorized();
            }

            return View(task);
        }

        [HttpPost]
        [Authorize(Roles = DefaultUserRole)]
        public async Task<IActionResult> Forfeit(string taskId, TaskInspectViewModel model)
        {
            if (model == null || taskId == null)
            {
                return BadRequest();
            }

            await taskService.ForfeitTaskAsync(taskId);

            return RedirectToAction(nameof(BetaProgramController.Mine), "BetaProgram");
        }
    }
}
