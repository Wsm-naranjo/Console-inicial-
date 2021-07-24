using System;
using System.Collections.Generic;

namespace Arbol3
{
    public class Nodo
    {
        //Clase 23-06-2021
        private string _valor;
        public Nodo()
        {
        }
        public Nodo(string valor)
        {
            Console.WriteLine("Estoy en el constructor.");
            Valor = valor;            
        }       

        public string Valor { get { return _valor; } set {
                Console.WriteLine("Estoy en la propiedad.");
                _valor = value; } }
        public Nodo Izquierdo { get; set; }
        public Nodo Derecho { get; set; }
    }
}
