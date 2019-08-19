using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _02_Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _02_Fiap.Web.AspNet.Controllers
{
    public class FormularioController : Controller
    {

        private static IList<Pessoa> _lista = new List<Pessoa>();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Pessoa pessoa)
        {
            ViewData["name"] = pessoa.Name;
            ViewData["dataNascimento"] = pessoa.DataNascimento ;
            Console.WriteLine("QUEM É " + pessoa.Email);
            ViewData["email"] = pessoa.Email;
            ViewBag.usuario = pessoa.Name;
            TempData["message"] = "Usuário Cadastrado";
            _lista.Add(pessoa);
            return View(pessoa);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_lista);
        }
    }
}