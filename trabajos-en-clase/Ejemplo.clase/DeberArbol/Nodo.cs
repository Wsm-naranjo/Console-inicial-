using System;
using System.Collections.Generic;

namespace Arbol2
{
    class Nodo
    {
        public string ID { get; set; }
        public string Valor { get; set; }
        public List<Nodo> Hijos { get; set; } = new List<Nodo>();
        
    }
}
