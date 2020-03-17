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
using Date.Repository;
using Date.Models;

namespace ColumnsAdministrator.Controllers
{
    public class HomeController : Controller
    {
        public IEFGenericRepository<ProductModels> Productsrepozitory { get; set; }
        public HomeController( IEFGenericRepository<ProductModels> products) 
        {
            Productsrepozitory = products;
        }
        [Authorize(Roles = "admin, user")]
        public IActionResult Index()
        {
            string role = User.FindFirst(x => x.Type == ClaimsIdentity.DefaultRoleClaimType).Value;
            return RedirectToAction("Product");
        }
        [Authorize(Roles = "admin")]
        public IActionResult Product()
        {
            ViewBag.products = Productsrepozitory.Get();
            return View();
        }
    }
}
