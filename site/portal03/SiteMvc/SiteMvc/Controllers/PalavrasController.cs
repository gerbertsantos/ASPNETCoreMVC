using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SiteMvc.Models;

namespace SiteMvc.Controllers
{
    public class PalavrasController : Controller
    {
        //Listar todos os regirtros do banco de dados
        public IActionResult Index()
        {
            return View();
        }

        //Criar o CRUD

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm] Palavra palavra)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Atualizar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm] Palavra palavra)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            return Redirect("Index");
        }

    }
}