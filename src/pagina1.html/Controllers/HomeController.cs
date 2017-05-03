using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace pagina1.html.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HTMLPage3()
        {
           
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Estudo para o teste de DA2";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Licenciatura em Gestão de Sistemas de Informação";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        public IActionResult exercicio3um()
        {
            return View();
        }
        public IActionResult exercicio3dois()
        {
            return View();
        }
        public IActionResult trestres()
        {
            return View();
        }
        public IActionResult exercicio3quatro()
        {
            return View();
        }
        public IActionResult Duvidas()
        {
            return View();
        }



    }
}
