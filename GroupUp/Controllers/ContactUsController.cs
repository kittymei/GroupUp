using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GroupUp.Models;

namespace GroupUp.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly GroupUpContext _context;

        public ContactUsController(GroupUpContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
       public async Task <IActionResult> Index(ContactUs contactUs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactUs);
                 await _context.SaveChangesAsync();
                return View("ContactUsForm",contactUs);
            }
            else
            {
                return View();
            }
        }

        public IActionResult ContactUsForm()
        {
            return View();
        }
    }
}
