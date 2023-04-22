using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PasswordGenerator.Models;

namespace PasswordGenerator.Controllers
{
    public class PasswordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckCompromisedPassword(string password)
        {
            bool isCompromised = PasswordChecker.IsPasswordCompromised(password);
            if (isCompromised)
            {
                ViewBag.AlertType = "danger";
                ViewBag.Message = "This password has been compromised. Please choose a different one.";
            }
            else
            {
                ViewBag.AlertType = "success";
                ViewBag.Message = "This password has not been compromised.";
            }
            return View("Index");
        }
    }
}
