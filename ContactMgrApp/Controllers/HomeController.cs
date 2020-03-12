//CSC 237
//Aliaksandra Hrechka
//02/16/2020
using ContactMgrApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactMgrApp.Controllers
{
    public class HomeController: Controller
    {
        private ContactContext context { get; set; }// injected

        public HomeController(ContactContext ctx)
        {
            context = ctx;//this controller now has access to the database
        }
        public IActionResult Index()//returnes list of contacts
        {
            var contacts = context.Contacts
                .Include(c => c.Category)
                .OrderBy(c => c.FirstName).ToList();
            return View(contacts);
        }
    }
}
