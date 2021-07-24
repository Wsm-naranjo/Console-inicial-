using System;
using System.Collections.Generic;

namespace Arbol3
{
    class Program
    {
        //Clase 23-06-2021
        static void Main(string[] args)
        {
            new Nodo()
            {
                Valor = "-",
                Izquierdo = new Nodo("5"),
                Derecho = new Nodo("3")
            };
            var raiz = new Nodo
            {
                Valor = "*",
                Izquierdo = new Nodo()
                {
                    Valor = "+",
                    Izquierdo = new Nodo("5"),
                    Derecho = new Nodo("3")
                }
            };
            Console.WriteLine(raiz.Izquierdo.Valor);
            raiz.Derecho = new Nodo()
            {
                Valor = "+",
                Izquierdo = new Nodo()
                {
                    Valor = "7"
                },
                Derecho = new Nodo()
                {
                    Valor = "4"
                }      
            };

        }
    }
}
