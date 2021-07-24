using System;
using System.Linq;

namespace Arbol2
{
    class ManejadorArbol
    {
        //Metodo recursivo, porque se llama asi mismo
        internal string ImprimirArbolInfijo(Nodo nodo)
        {
            //Analiza el comportamiento de una hoja
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            //Analizo cuando no soy hoja
             return $"( {ImprimirArbolInfijo(nodo.Hijos[0])} {nodo.Valor} {ImprimirArbolInfijo(nodo.Hijos[1])})";
         }
        internal string ImprimirArbolPrefijo(Nodo nodo)
        {
            //Analiza el comportamiento de una hoja
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            //Analizo cuando no soy hoja
            return $"({nodo.Valor} {ImprimirArbolPrefijo(nodo.Hijos[0])} {ImprimirArbolPrefijo(nodo.Hijos[1])})";
        }
        internal string ImprimirArbolPostFijo(Nodo nodo)
        {
            //Analiza el comportamiento de una hoja
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            //Analizo cuando no soy hoja
            return $" ({ImprimirArbolPostFijo(nodo.Hijos[0])} {ImprimirArbolPostFijo(nodo.Hijos[1])} {nodo.Valor})";

        }
        internal string ImprimirArbol(Nodo nodo,Notacion notacion)
        {
            //Analiza el comportamiento de una hoja
            if (!nodo.Hijos.Any())
                return nodo.Valor;
                        
            return notacion switch
            {
                Notacion.Infijo => $"( {ImprimirArbol(nodo.Hijos[0], notacion)} {nodo.Valor} {ImprimirArbol(nodo.Hijos[1], notacion)})",
                Notacion.Prefijo => $"({nodo.Valor} {ImprimirArbol(nodo.Hijos[0], notacion)} {ImprimirArbol(nodo.Hijos[1], notacion)})",
                Notacion.Postfijo => $" ({ImprimirArbol(nodo.Hijos[0], notacion)} {ImprimirArbol(nodo.Hijos[1], notacion)} {nodo.Valor})",
                _ => "Tipo de notacion no implementada",
            };
            /*switch (notacion)
            {
                case Notacion.Infijo:
                    return $"( {ImprimirArbol(nodo.Hijos[0],notacion)} {nodo.Valor} {ImprimirArbol(nodo.Hijos[1], notacion)})";
                case Notacion.Prefijo:
                    return $"({nodo.Valor} {ImprimirArbol(nodo.Hijos[0], notacion)} {ImprimirArbol(nodo.Hijos[1], notacion)})";

                case Notacion.Postfijo:
                    return $" ({ImprimirArbol(nodo.Hijos[0], notacion)} {ImprimirArbol(nodo.Hijos[1], notacion)} {nodo.Valor})";
                default:
                    return "Tipo de notacion no implementada";
            }
            */
        }
        
        internal int NumeroHojas(Nodo nodo)
        {
            if (SoyHoja(nodo))
                return 1;

            int totalHojas = 0 ;
            foreach (var hijoActual in nodo.Hijos)
            {
                totalHojas += NumeroHojas(hijoActual);
                
            }

            return totalHojas;

            /*var hojasHijo1 = NumeroHojas(nodo.Hijos[0]);
            var hojasHijo2 = NumeroHojas(nodo.Hijos[1]);
            var hojasHijo3 = NumeroHojas(nodo.Hijos[2]);
            //...

            var hojasHijoUltimo= NumeroHojas(nodo.Hijos[nodo.Hijos.Count -1]); //n=> count

            return hojasHijo1 + hojasHijo2 + hojasHijo3 + hojasHijoUltimo;*/
        }
        internal int NumeroNodos(Nodo nodo)
        {
            if (SoyHoja(nodo))
                return 1;

            int totalNodos = 0;
            foreach(var nodoActual in nodo.Hijos)
            {
                totalNodos += NumeroNodos(nodoActual);
            }
            return totalNodos + 1;
        }

        internal int NumeroNiveles(Nodo nodo)
        {
            if (nodo == null)
                return 0;

            var nivelHijos = 0;
            foreach (var nodoActual in nodo.Hijos)
            {
                var nivelActual = NumeroNiveles(nodoActual);                
                if (nivelHijos < nivelActual)
                    nivelHijos = nivelActual;                
            }
            return ++nivelHijos;
        }
        private bool SoyHoja(Nodo nodo)
        {
            return !nodo.Hijos.Any();
        }       

    }  
}




















        /*static void Main(string[] args)
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
    class Nodo
    {
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
    }*/

