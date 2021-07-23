﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SebastianNaranjoExamenWeb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SebastianNaranjoExamenWeb.Controllers
{
    public class ConsultaController : Controller
    {
        public IActionResult NodosNavegacion()
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

            return Nodo.Navegar(arbol));

        }
    }
}