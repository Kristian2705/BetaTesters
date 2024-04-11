﻿using BetaTesters.Core.Contracts;
using BetaTesters.Core.Models.BetaProgram;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BetaTesters.Controllers
{
	public class BetaProgramController : BaseController
	{
		private readonly IBetaProgramService betaProgramService;

        public BetaProgramController(IBetaProgramService _betaProgramService)
        {
            betaProgramService = _betaProgramService;
        }

        //The details button for the programs should be implemented later
        [HttpGet]
		[AllowAnonymous]
        public async Task<IActionResult> All([FromQuery]AllBetaProgramsQueryModel query)
		{
			var model = await betaProgramService.AllAsync(query.CurrentPage, AllBetaProgramsQueryModel.BetaProgramsPerPage);

			query.TotalBetaProgramsCount = model.TotalBetaProgramsCount;
			query.BetaPrograms = model.BetaPrograms;

			return View(query);
		}
	}
}