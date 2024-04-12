using BetaTesters.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

namespace BetaTesters.Attributes
{
    public class IsNotReviewed : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
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

            string applicationId = context.HttpContext.Request.RouteValues["id"].ToString();

            if (candidateApplicationService != null && candidateApplicationService.GetById(applicationId).Approval != 0)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status400BadRequest);
            }
        }
    }
}
