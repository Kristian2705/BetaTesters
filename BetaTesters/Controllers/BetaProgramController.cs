using BetaTesters.Core.Contracts;
using BetaTesters.Core.Models.ApplicationUserModels;
using BetaTesters.Core.Models.BetaProgram;
using BetaTesters.Infrastructure.Data.Enums;
using BetaTesters.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using static BetaTesters.Infrastructure.Constants.RoleConstants;

namespace BetaTesters.Controllers
{
    public class BetaProgramController : BaseController
	{
		private readonly IBetaProgramService betaProgramService;
        private readonly IApplicationUserService applicationUserService;
        private readonly UserManager<ApplicationUser> userManager;

        public BetaProgramController(IBetaProgramService _betaProgramService,
            IApplicationUserService _applicationUserService,
            UserManager<ApplicationUser> _userManager)
        {
            betaProgramService = _betaProgramService;
            applicationUserService = _applicationUserService;
            userManager = _userManager;
        }

        //The details button for the programs should be implemented later
        [HttpGet]
		[AllowAnonymous]
        public async Task<IActionResult> All([FromQuery]AllBetaProgramsQueryModel query)
		{
            try
            {
                var model = await betaProgramService.AllAsync(query.CurrentPage, AllBetaProgramsQueryModel.BetaProgramsPerPage);
                query.TotalBetaProgramsCount = model.TotalBetaProgramsCount;
                query.BetaPrograms = model.BetaPrograms;

                return View(query);
            }
            catch (Exception)
            {
                return GeneralError();
            }
		}

        [HttpGet]
		public async Task<IActionResult> Details(string id)
		{
            if (await betaProgramService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            try
            {
                var model = await betaProgramService.BetaProgramDetailsByIdAsync(id);

                return View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpGet]
        [Authorize(Roles = OwnerRole)]
        public async Task<IActionResult> Add()
        {
            if((await applicationUserService.GetApplicationUserByIdAsync(User.Id())).BetaProgramId != null)
            {
                return BadRequest();
            }

            var model = new BetaProgramFormModel();

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = OwnerRole)]
        public async Task<IActionResult> Add(BetaProgramFormModel model)
        {
			if (!ModelState.IsValid)
			{
				return View(model);
			}

			try
			{
				string programId = (await betaProgramService.CreateAsync(model)).ToString();

                var user = await applicationUserService.GetApplicationUserByIdAsync(User.Id());

                await applicationUserService.SetProgramIdAsync(user, programId);
			}
			catch (Exception)
			{
				GeneralError();
			}

			return RedirectToAction(nameof(All));
		}

        [HttpGet]
        public async Task<IActionResult> Mine()
        {
            var userId = User.Id();

            if ((await applicationUserService.GetApplicationUserByIdAsync(User.Id())).BetaProgramId == null)
            {
                if (User.IsInRole(OwnerRole))
                {
                    ViewBag.DisplayMessage = "You have not created a program yet!";
                }
                else
                {
                    ViewBag.DisplayMessage = "You have not joined a program yet!";
                }
                return View(null);
            }

            var model = await betaProgramService.BetaProgramByUserId(userId);

            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = $"{ModeratorRole},{OwnerRole}")]
        public async Task<IActionResult> SeeUsersInfo(string programId)
        {
            var user = await applicationUserService.GetApplicationUserByIdAsync(User.Id());

            if (user.BetaProgramId != Guid.Parse(programId))
            {
                return Unauthorized();
            }

            if (programId == null)
            {
                return BadRequest();
            }

            var usersInProgram = await applicationUserService.GetUsersByProgramId(programId);

            return View(usersInProgram);
        }

        [HttpGet]
        [Authorize(Roles = OwnerRole)]
        public async Task<IActionResult> SeeModeratorsInfo(string programId)
        {
            var user = await applicationUserService.GetApplicationUserByIdAsync(User.Id());

            if(user.BetaProgramId != Guid.Parse(programId))
            {
                return Unauthorized();
            }

            if (programId == null)
            {
                return BadRequest();
            }

            var moderatorsInProgram = await applicationUserService.GetModeratorsByProgramId(programId);

            return View(moderatorsInProgram);
        }

        [HttpGet]
        [Authorize(Roles = OwnerRole)]
        public async Task<IActionResult> Promote(string userId)
        {
            var user = await applicationUserService.GetApplicationUserByIdAsync(userId);

            var owner = await applicationUserService.GetApplicationUserByIdAsync(User.Id());

            if(user.BetaProgramId != owner.BetaProgramId)
            {
                return Unauthorized();
            }

            if (await userManager.IsInRoleAsync(user, ModeratorRole))
            {
                return BadRequest();
            }

            var userToDisplay = applicationUserService.GetApplicationUserViewModelByUser(user);

            return View(userToDisplay);
        }

        [HttpPost]
        [Authorize(Roles = OwnerRole)]
        public async Task<IActionResult> Promote(string userId, ApplicationUserViewModel model)
        {
            if(model == null)
            {
                return BadRequest();
            }

            var user = await applicationUserService.GetApplicationUserByIdAsync(userId);

            await applicationUserService.PromoteUserToModeratorAsync(user);

            return RedirectToAction(nameof(Mine));
        }

        [HttpGet]
        [Authorize(Roles = $"{DefaultUserRole},{ModeratorRole}")]
        public async Task<IActionResult> Leave(string programId)
        {
            if(programId == null)
            {
                return BadRequest();
            }

            var user = await applicationUserService.GetApplicationUserByIdAsync(User.Id());

            if(user.BetaProgramId != Guid.Parse(programId))
            {
                return BadRequest();
            }

            if (user.Tasks.Any(t => t.State == TaskState.InProgress))
            {
                return BadRequest("You should first complete or forfeit your tasks before leaving!");
            }

            var programDetails = await betaProgramService.BetaProgramDetailsByIdAsync(programId);

            return View(programDetails);
        }

        [HttpPost]
        [Authorize(Roles = $"{DefaultUserRole},{ModeratorRole}")]
        public async Task<IActionResult> Leave(string programId, BetaProgramDetailsServiceModel model)
        {
            if (programId == null)
            {
                return BadRequest();
            }

            await betaProgramService.LeaveAsync(User.Id());

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}
