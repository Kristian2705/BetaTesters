﻿using BetaTesters.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static BetaTesters.Infrastructure.Constants.RoleConstants;

namespace BetaTesters.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> logger;

        public HomeController(ILogger<HomeController> _logger)
        {
            logger = _logger;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            if (User.IsInRole(AdminRole))
            {
                return RedirectToAction(nameof(Index), "Home", new { area = "Admin"} );
            }

            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            if(statusCode == 400)
            {
                return View("Error400");
            }
             
            if(statusCode == 401)
            {
                return View("Error401");
            }

            if(statusCode == 404)
            {
                return View("Error404");
            }

            return View();
        }
    }
}