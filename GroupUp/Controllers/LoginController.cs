using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupUp.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroupUp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
