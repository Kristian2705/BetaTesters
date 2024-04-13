using BetaTesters.Core.Contracts;
using BetaTesters.Core.Models.BetaProgram;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using static BetaTesters.Infrastructure.Constants.RoleConstants;

namespace BetaTesters.Controllers
{
    public class BetaProgramController : BaseController
	{
		private readonly IBetaProgramService betaProgramService;
        private readonly IApplicationUserService applicationUserService;

        public BetaProgramController(IBetaProgramService _betaProgramService,
            IApplicationUserService _applicationUserService)
        {
            betaProgramService = _betaProgramService;
            applicationUserService = _applicationUserService;
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
        public IActionResult Add()
        {
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
    }
}
