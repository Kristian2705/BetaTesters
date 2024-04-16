using Microsoft.AspNetCore.Mvc;

namespace BetaTesters.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        public IActionResult Index()
            => View();
    }
}
