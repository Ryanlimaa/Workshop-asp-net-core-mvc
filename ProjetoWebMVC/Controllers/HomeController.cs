using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoWebMVC.Models;

namespace ProjetoWebMVC.Controllers
{
    public class HomeController : Controller
    {
        //Resultado de uma acao
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            ViewData["Message"] = "Sistema de vendas web MVC";
            ViewData["Autor"] = "Ryan Lima";

            return View();
        }

        public IActionResult Contato()
        {
            ViewData["Message"] = "Informações para contato";

            return View();
        }

        public IActionResult Privacidade()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
