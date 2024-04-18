using BetaTesters.Core.Contracts;
using BetaTesters.Core.Models.CandidateApplication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using BetaTesters.Attributes;
using static BetaTesters.Infrastructure.Constants.RoleConstants;

namespace BetaTesters.Controllers
{
    public class CandidateApplicationController : BaseController
    {
        private readonly ICandidateApplicationService candidateApplicationService;
        private readonly IApplicationUserService applicationUserService;

        public CandidateApplicationController(ICandidateApplicationService _candidateApplicationService,
            IApplicationUserService _applicationUserService)
        {
            candidateApplicationService = _candidateApplicationService;
            applicationUserService = _applicationUserService;
        }

        [HttpGet]
        [NotSubmittedApplication]
        [Authorize(Roles = DefaultUserRole)]
        public async Task<IActionResult> Add(string id)
        {
            if(id == null)
            {
                return BadRequest();
            }

            var user = await applicationUserService.GetApplicationUserByIdAsync(User.Id());

            if(user.BetaProgramId != null)
            {
                return Unauthorized();
            }

            var model = new CandidateApplicationFormModel
            {
                BetaProgramId = id
            };

            return View(model);
        }


        //When an application is sent to another program and they accept you in the first one, the others should be automatically deleted
        [HttpPost]
        [NotSubmittedApplication]
        [Authorize(Roles = DefaultUserRole)]
        public async Task<IActionResult> Add(CandidateApplicationFormModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            if(model.BetaProgramId == null)
            {
                return BadRequest();
            }

            try
            {
                await candidateApplicationService.CreateAsync(model, User.Id(), model.BetaProgramId);
            }
            catch(Exception)
            {
                GeneralError();
            }

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [HttpGet]
        [Authorize(Roles = DefaultUserRole)]
        public async Task<IActionResult> Mine()
        {
            var userId = User.Id();

            var models = await candidateApplicationService.ApplicationsByUserIdAsync(userId);

            return View(models);
        }

        [HttpGet]
        [IsNotReviewed]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            if (await candidateApplicationService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            if (candidateApplicationService.GetById(id).CandidateId != Guid.Parse(User.Id()))
            {
                return Unauthorized();
            }

            var model = await candidateApplicationService.GetCandidateApplicationFormModelByIdAsync(id);

            return View(model);
        }

		[HttpPost]
        [IsNotReviewed]
		public async Task<IActionResult> Edit(string id, CandidateApplicationFormModel application)
        {
            if (id == null)
            {
                return BadRequest();
            }

            if (await candidateApplicationService.ExistsAsync(id) == false)
			{
				return BadRequest();
			}

            if (candidateApplicationService.GetById(id).CandidateId != Guid.Parse(User.Id()))
            {
                return Unauthorized();
            }

            if (!ModelState.IsValid)
			{
				return View(application);
			}

			await candidateApplicationService.EditAsync(id, application);

			return RedirectToAction(nameof(Mine));
		}

        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            if (candidateApplicationService.GetById(id).CandidateId != Guid.Parse(User.Id()))
            {
                return Unauthorized();
            }

            var application = await candidateApplicationService.CandidateApplicationDetailsByIdAsync(id);

            return View(application);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(CandidateApplicationViewModel model)
        {
            if (model == null)
            {
                return BadRequest();
            }

            if (candidateApplicationService.GetById(model.Id.ToString()).CandidateId != Guid.Parse(User.Id()))
            {
                return Unauthorized();
            }

            await candidateApplicationService.DeleteAsync(model.Id.ToString());

            return RedirectToAction(nameof(Mine));
        }

        [HttpGet]
        [Authorize(Roles = $"{ModeratorRole},{OwnerRole}")]
        public async Task<IActionResult> AllCurrentProgram(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var user = await applicationUserService.GetApplicationUserByIdAsync(User.Id());

            if(user.BetaProgramId.ToString() != id)
            {
                return Unauthorized();
            }

            var models = await candidateApplicationService.ApplicationsByProgramIdAsync(id);

            return View(models);
        }

        [HttpGet]
        [Authorize(Roles = $"{ModeratorRole},{OwnerRole}")]
        public async Task<IActionResult> Approve(string id)
        {
            if(id == null)
            {
                return BadRequest();
            }

            var user = await applicationUserService.GetApplicationUserByIdAsync(User.Id());

            var application = await candidateApplicationService.CandidateApplicationInspectDetailsByIdAsync(id);

            if(user.BetaProgramId != application.BetaProgramId)
            {
                return Unauthorized();
            }
            
            return View(application);
        }

        [HttpPost]
        [Authorize(Roles = $"{ModeratorRole},{OwnerRole}")]
        public async Task<IActionResult> Approve(string candidateId, CandidateApplicationInspectModel model)
        {
            if(model == null || candidateId == null)
            {
                return BadRequest();
            }

            var betaProgramId = model.BetaProgramId.ToString();

            await candidateApplicationService.ApproveApplicationAsync(model.Id.ToString(), candidateId, betaProgramId);

            return RedirectToAction(nameof(Mine), "BetaProgram");
        }

        [HttpGet]
        [Authorize(Roles = $"{ModeratorRole},{OwnerRole}")]
        public async Task<IActionResult> Reject(string id)
        {
            if(id == null)
            {
                return BadRequest();
            }

            var user = await applicationUserService.GetApplicationUserByIdAsync(User.Id());

            var application = await candidateApplicationService.CandidateApplicationInspectDetailsByIdAsync(id);

            if (user.BetaProgramId != application.BetaProgramId)
            {
                return Unauthorized();
            }

            return View(application);
        }

        [HttpPost]
        [Authorize(Roles = $"{ModeratorRole},{OwnerRole}")]
        public async Task<IActionResult> Reject(CandidateApplicationInspectModel model)
        {
            if (model == null)
            {
                return BadRequest();
            }

            var betaProgramId = model.BetaProgramId.ToString();

            await candidateApplicationService.DeleteAsync(model.Id.ToString());

            return RedirectToAction(nameof(Mine), "BetaProgram");
        }
    }
}
