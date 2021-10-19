using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Models;

namespace WebTest.Controllers
{
    public class HomeController : Controller
    {
      //  private readonly ILogger<HomeController> _logger;
      //
      //  public HomeController(ILogger<HomeController> logger)
      //  {
      //      _logger = logger;
      //  }

        private readonly UsersRepository usersRepository;
       

        public HomeController(UsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public IActionResult Index()
        {
            var model = usersRepository.GetUsers();
            return View(model);
        }

        public IActionResult UsersEdit(Guid id)
        {
            Users model = id == default ? new Users() : usersRepository.GetUserById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult UsersEdit(Users model)
        {
            if (ModelState.IsValid)
            {
                usersRepository.SaveUser(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }
        [HttpPost]
        public IActionResult UsersDelete(Guid id)
        {
            usersRepository.DeleteUser(new Users { Id = id });
            return RedirectToAction("Index");
        }

        /// <summary>
        /// //////////
        /// </summary>
        /// <returns></returns>
        

        public IActionResult PhoneEdit(Guid id)
        {
            Phone model = id == default ? new Phone() : usersRepository.GetPhoneById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult PhoneEdit(Phone model)
        {
            if (ModelState.IsValid)
            {
                usersRepository.SavePhone(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }
        [HttpPost]
        public IActionResult PhoneDelete(Guid id)
        {
            usersRepository.DeletePhone(new Phone { Id = id });
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
