using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using PasswordGenerator.Models;


//this is the logic for Generating a random password. 
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace FinalPasswordGen.Controllers
{
    public class PasswordGeneratorController : Controller
    {
        public IActionResult GeneratePassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            const int passwordLength = 10;

            var random = new Random();
            var password = new StringBuilder(passwordLength);
            for (int i = 0; i < passwordLength; i++)
            {
                password.Append(chars[random.Next(chars.Length)]);
            }

            ViewBag.Password = password.ToString();

            return View();
        }
    }
}



//This Is the password Checker

