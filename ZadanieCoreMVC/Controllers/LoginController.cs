using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZadanieCoreMVC.Models;

namespace ZadanieCoreMVC.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View("Login", new UserViewModel());
        }

        public ActionResult Summary(UserViewModel userViewModel)
        {
            return View(userViewModel);
        }

        public ActionResult Login(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Summary), userViewModel);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
