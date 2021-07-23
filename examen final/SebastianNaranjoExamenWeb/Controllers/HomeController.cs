using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SebastianNaranjoExamenWeb.Entities;
using SebastianNaranjoExamenWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SebastianNaranjoExamenWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult NodoVista(string nombre, string apellido)
        {
            Nodo arbol = new Nodo { Valor = 10.5f };

            var nodo3 = new Nodo { Valor = 55.2f };

            var nodo4 = new Nodo { Valor = -7f };

            var nodo5 = new Nodo { Valor = 3.1e2 };

            var nodo6 = new Nodo { Valor = -7f };

            var nodo1 = new Nodo { Valor = 15.2f };

            nodo1.NodosHijos.Add(nodo3);

            nodo1.NodosHijos.Add(nodo4);

            var nodo2 = new Nodo { Valor = -7f };

            nodo2.NodosHijos.Add(nodo5);

            nodo2.NodosHijos.Add(nodo6);

            arbol.NodosHijos.Add(nodo1);

            arbol.NodosHijos.Add(nodo2);

            return Console.WriteLine(Navegar(arbol));
        }
    }
}
