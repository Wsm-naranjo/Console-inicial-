using System;
using System.Collections;
using System.Collections.Generic;

namespace Arbol2
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Nodo raiz = new Nodo()
            {
                Valor = "*",
                Hijos =
                {
                    new Nodo
                    {
                        Valor = "+",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "8"
                            },
                            new Nodo
                            {
                                Valor = "5"
                            },
                        }
                    },
                    new Nodo
                    {
                        Valor = "-",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "7"
                            },
                            new Nodo
                            {
                                Valor = "4"
                            }
                        }
                    }
                }
                
            };
            //Resultado esperado
            //=> (8+5) * (7-4) = 39 notacion infija
            //=> * (+8 5)(-7 4) = 39 notacion prefija
            //=> (8 5+)(7 4-) *  = 39 notacion postfija


            //=> 8+ (5*7) -4 = 39 
            //Ortogonalidad
            ManejadorArbol manejadorArbol = new ManejadorArbol();
            Console.WriteLine(manejadorArbol.ImprimirArbolInfijo(raiz));
            Console.WriteLine(manejadorArbol.ImprimirArbolPrefijo(raiz));
            Console.WriteLine(manejadorArbol.ImprimirArbolPostFijo(raiz));

            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz, Notacion.Infijo));
            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz, Notacion.Prefijo));
            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz, Notacion.Postfijo));

            var raiz1 = new Nodo
            {
                Valor = "a",
                Hijos =
                {
                    new Nodo
                    {
                        Valor ="p1",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor ="h1"
                            },
                            new Nodo
                            {
                                Valor ="h2",
                                Hijos =
                                {
                                    new Nodo
                                    {
                                        Valor ="b1"
                                    },
                                    new Nodo
                                    {
                                        Valor ="b2"
                                    }
                                }
                            }
                        }
                    },
                    new Nodo
                    {
                        Valor = "p2",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor ="h1"
                            },
                            new Nodo
                            {
                                Valor ="h2",
                                Hijos =
                                {
                                    new Nodo
                                    {
                                        Valor ="b1",
                                        Hijos =
                                        {
                                            new Nodo
                                            {
                                            Valor ="c1"
                                            },
                                            new Nodo
                                            {
                                            Valor ="c2"
                                            }
                                        }
                                    },
                                    new Nodo
                                    {
                                        Valor ="b2",
                                        Hijos =
                                        {
                                            new Nodo
                                            {
                                                Valor ="c1",
                                                Hijos =
                                                {
                                                    new Nodo
                                                    {
                                                    Valor ="f1"
                                                    },
                                                    new Nodo
                                                    {
                                                    Valor ="f2"
                                                    }
                                                }
                                            },
                                            new Nodo
                                            {
                                            Valor ="c2"
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }                    
            };

            Console.WriteLine($"Numero de hojas: {manejadorArbol.NumeroHojas(raiz)}");
            Console.WriteLine($"Numero de nodos: {manejadorArbol.NumeroNodos(raiz1)}");
            Console.WriteLine($"Numero de niveles: {manejadorArbol.NumeroNiveles(raiz1)}");

            // Queue queue = new Queue();
            // FIFO = First in first out 
            // queue.Enqueue = new Nodo(); //colaca atras
            // Nodo nodo = (Nodo)queue.Dequeue();//saca de adelante
            // Nodo nodo1 = (Nodo)queue.Peek();
        }

    }
}

