using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SiteMvc.Models;

namespace SiteMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Login");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm] Usuario usuario)
        {
            if (ModelState.IsValid) { 
                if (usuario.Email == "teste@app.com" && usuario.Senha == "123456")
                {
                    return RedirectToAction("Index", "Palavras");
                }
                else
                {
                    ViewBag.Message = "Login ou senha inválidos.";
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
    }
}