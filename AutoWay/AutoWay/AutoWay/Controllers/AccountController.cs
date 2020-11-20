using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using AutoWay.Extentions;
using AutoWay.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BC = BCrypt.Net.BCrypt;
namespace AutoWay.Controllers
{
    public class AccountController : Controller
    {
        private readonly AutoWayContext _context;

        public AccountController(AutoWayContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var details = await _context.TblUsers
                    .SingleOrDefaultAsync(m => m.Username == loginViewModel.Username);
                if (details == null || !BC.Verify(loginViewModel.Password, details.PasswordHash))
                {
                    ModelState.AddModelError("Password", "Invalid Login Attempt.");
                    return View("Index");
                }
                HttpContext.Session.SetString("userId", details.Username);
            }
            else
            {
                return View("Index");
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<ActionResult> Registar(RegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                TblUser user = new TblUser
                {
                    Username = model.Username,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Gender = model.Gender,
                    City = model.City,
                    Address = model.Address,
                    PhoneNumber = model.PhoneNumber,
                    Email = model.Email,
                    Password = model.Password,
                    PasswordHash = BC.HashPassword(model.Password),
                    AuthKey = ("a"+model.Email.GetMd5Hash()).ToString(),
                    CreatedAt = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss")
                };
                _context.Add(user);
                await _context.SaveChangesAsync();
            }
            else
            {
                return View("Registration");
            }

            return RedirectToAction("Index", "Account");
        }

        // registration Page load
        public IActionResult Registration()
        {
            ViewData["Message"] = "Registration Page";

            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }

        public void ValidationMessage(string key, string alert, string value)
        {
            try
            {
                TempData.Remove(key);
                TempData.Add(key, value);
                TempData.Add("alertType", alert);
            }
            catch
            {
                Debug.WriteLine("TempDataMessage Error");
            }

        }
    }
}
