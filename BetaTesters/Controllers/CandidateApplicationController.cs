using BetaTesters.Core.Contracts;
using BetaTesters.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
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

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new CandidateApplicationFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CandidateApplicationFormModel model, string programId)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await candidateApplicationService.CreateAsync(model, User.Id(), programId);
            }
            catch(Exception)
            {
                GeneralError();
            }

            return RedirectToAction(nameof(HomeController.Index));
        }
    }
}
