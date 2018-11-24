using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SiteMvc.Database;
using SiteMvc.Models;

namespace SiteMvc.Controllers
{
    public class PalavrasController : Controller
    {

        private DatabaseContext _db;

        public PalavrasController(DatabaseContext db)
        {
            _db = db;
        }

        //Listar todos os regirtros do banco de dados
        public IActionResult Index()
        {
            //ViewBag.Palavras = _db.Palavras.ToList();
            var palavras = _db.Palavras.ToList();
            return View(palavras);
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
            //O mesmo formulário (Cadastrar) faz duas funções (Cadastrar e Atualizar), então no método peço para que me envie para o form de cadastro 
            return View("Cadastrar");
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm] Palavra palavra)
        {
            return View("Cadastrar");
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            return Redirect("Index");
        }

    }
}