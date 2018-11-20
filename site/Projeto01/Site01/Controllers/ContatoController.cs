using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Site01.Models;

namespace Site01.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult receberContato([FromForm] Contato contato)
        {
            string conteudo = string.Format("Nome: {0}, E-mail: {1}, Assunto: {2}, Mensagem: {3}", contato.nome, contato.email, contato.assunto, contato.mensagem);
            return new ContentResult { Content = conteudo };
        }

        /* obter manualmente
        public ActionResult receberContato()
        {

            Contato contato = new Contato();

            contato.nome = Request.Form["nome"];
            contato.email = Request.Form["email"];
            contato.assunto = Request.Form["assunto"];
            contato.mensagem = Request.Form["mensagem"];

            string conteudo = string.Format( "Nome: {0}, E-mail: {1}, Assunto: {2}, Mensagem: {3}", contato.nome, contato.email, contato.assunto, contato.mensagem );
            return new ContentResult { Content = conteudo  };
        }
        */
    }
}