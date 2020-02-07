using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ColumnsAdministrator.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace ColumnsAdministrator.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles = "admin, user")]
        public IActionResult Index()
        {
            string role = User.FindFirst(x => x.Type == ClaimsIdentity.DefaultRoleClaimType).Value;
            return Content($"ваша роль: {role}");
        }
        [Authorize(Roles = "admin")]
        public IActionResult About()
        {
            return Content("Вход только для администратора");
        }
    }
}
