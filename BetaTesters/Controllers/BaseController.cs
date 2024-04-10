using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BetaTesters.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        protected IActionResult GeneralError()
        {
            TempData["ErrorMessage"] = "An unexpected error occured! Please try again later!";
            return RedirectToAction("Index", "Home");
        }
    }
}
