using Microsoft.AspNetCore.Mvc;
using ProjetoWebMVC.Models;
using System.Collections.Generic;

namespace ProjetoWebMVC.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento { Id = 1, Name = "Eletronicos" });
            list.Add(new Departamento { Id = 2, Name = "Fashion" });

            return View(list);
        }
    }
}
