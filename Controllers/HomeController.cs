using ProjetoInstagram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoInstagram.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "gabriel",
                Tipo = "administador"
            };

            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;




            return View();
        }

        public ActionResult Contatos()
        {
            return View();
        }

    }
}