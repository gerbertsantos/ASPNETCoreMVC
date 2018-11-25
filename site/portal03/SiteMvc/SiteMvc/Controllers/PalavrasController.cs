using System.Linq;
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
            return View(new Palavra());
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm] Palavra palavra)
        {
            if (ModelState.IsValid)
            {
                _db.Palavras.Add(palavra);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
          
            return View();
        }

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            //O mesmo formulário (Cadastrar) faz duas funções (Cadastrar e Atualizar), então no método peço para que me envie para o form de cadastro 
            Palavra palavra = _db.Palavras.Find(id);
            return View("Cadastrar", palavra);
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm] Palavra palavra)
        {
            if (ModelState.IsValid)
            {
                _db.Palavras.Update(palavra);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View("Cadastrar", palavra);
        }

        [HttpGet]
        public IActionResult Excluir(int Id)
        {
            Palavra palavra = _db.Palavras.Find(Id);
            _db.Palavras.Remove(palavra);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}