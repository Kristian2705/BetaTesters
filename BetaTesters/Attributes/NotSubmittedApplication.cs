using BetaTesters.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

namespace BetaTesters.Attributes
{
    public class NotSubmittedApplication : ActionFilterAttribute
    {
        public async override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            ICandidateApplicationService? candidateApplicationService = context
                .HttpContext
                .RequestServices
                .GetService<ICandidateApplicationService>();

            if (candidateApplicationService == null)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }

            string programId = context.HttpContext.Request.RouteValues["id"].ToString();

            bool hasSubmitted = await candidateApplicationService
                .HasApplicationForCurrentUserAndProgramAsync(context.HttpContext.User.Id(), programId);

            if (candidateApplicationService != null && hasSubmitted)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status400BadRequest);
            }
        }
    }
}
