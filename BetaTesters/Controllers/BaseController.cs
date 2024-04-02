using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BetaTesters.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {

    }
}
