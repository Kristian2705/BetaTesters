﻿using BetaTesters.Core.Contracts;
using BetaTesters.Core.Models.CandidateApplication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using BetaTesters.Attributes;
using static BetaTesters.Infrastructure.Constants.RoleConstants;

namespace BetaTesters.Controllers
{
    [Authorize(Roles = DefaultUserRole)]
    public class CandidateApplicationController : BaseController
    {
        public readonly ICandidateApplicationService candidateApplicationService;

        public CandidateApplicationController(ICandidateApplicationService _candidateApplicationService)
        {
            candidateApplicationService = _candidateApplicationService;
        }

        [HttpGet]
        [NotSubmittedApplication]
        public IActionResult Add(string id)
        {
            var model = new CandidateApplicationFormModel
            {
                BetaProgramId = id
            };

            return View(model);
        }

        [HttpPost]
        [NotSubmittedApplication]
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
            if (await candidateApplicationService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            var model = await candidateApplicationService.GetCandidateApplicationFormModelByIdAsync(id);

            return View(model);
        }

		[HttpPost]
        [IsNotReviewed]
		public async Task<IActionResult> Edit(string id, CandidateApplicationFormModel application)
        {
			if (await candidateApplicationService.ExistsAsync(id) == false)
			{
				return BadRequest();
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
            var application = await candidateApplicationService.CandidateApplicationDetailsByIdAsync(id);

            return View(application);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(CandidateApplicationViewModel model)
        {
            if(model == null)
            {
                return BadRequest();
            }

            await candidateApplicationService.DeleteAsync(model.Id.ToString());

            return RedirectToAction(nameof(Mine));
        }
	}
}
