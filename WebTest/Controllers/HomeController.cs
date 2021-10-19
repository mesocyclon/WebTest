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

        public HomeController(UsersRepository articlesRepository)
        {
            this.usersRepository = articlesRepository;
        }

        public IActionResult Index()
        {
            var model = usersRepository.GetUsers();
            return View(model);
        }

        public IActionResult UsersEdit(Guid id)
        {
            UsersModel model = id == default ? new UsersModel() : usersRepository.GetUserById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult UsersEdit(UsersModel model)
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
            usersRepository.DeleteUser(new UsersModel { Id = id });
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
