using System;
using System.Collections;
using System.Collections.Generic;

namespace Arbol2
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------BIENVENIDOS-----------------");
            Console.WriteLine("En este programa de consola te propone un reto en el que debes de resolver un ejercicio matematico sin la calculadora.");
            Console.WriteLine("OPERACION 1");
            Console.WriteLine("(4-2)*(3+3)/3");
            Console.WriteLine("Ingresa tu respuesta: ");

            var respuestas= Console.ReadLine();
            Respuesta respuesta = new Respuesta(respuestas);
            Console.WriteLine($"{respuesta.VerificarRespuesta()}");
                        
            Nodo raiz = new Nodo()
            {
                Valor = "*",
                Hijos =
                {
                    new Nodo
                    {
                        Valor = "-",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "4"
                            },
                            new Nodo
                            {
                                Valor = "2"
                            },
                        }
                    },
                    new Nodo
                    {
                        Valor = "+",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "3"
                            },
                            new Nodo
                            {
                                Valor = "3"
                            }
                        }
                    },
                    new Nodo
                    {
                        Valor = "/",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "3"
                            }
                        }
                    }
                }

            };
            respuestas = "";            
            ManejadorArbol manejadorArbol = new ManejadorArbol();

            Console.WriteLine("Esta operacion fue hecha con estructura de un arbol el cual tuvo:");
            Console.WriteLine($"Numero de hojas: {manejadorArbol.NumeroHojas(raiz)}");
            Console.WriteLine($"Numero de nodos: {manejadorArbol.NumeroNodos(raiz)}");
            Console.WriteLine($"Numero de niveles: {manejadorArbol.NumeroNiveles(raiz)}");
            Console.WriteLine("______________________________________________________________________");

            //(4 * 30) * (30 / 3) / (4 * 6)
            Nodo raiz1 = new Nodo()
            {
                Valor = "*",
                Hijos =
                {
                    new Nodo
                    {
                        Valor = "*",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "4"
                            },
                            new Nodo
                            {
                                Valor = "30"
                            },
                        }
                    },
                    new Nodo
                    {
                        Valor = "/",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "30"
                            },
                            new Nodo
                            {
                                Valor = "3"
                            }
                        }
                    },
                    new Nodo
                    {
                        Valor = "/",
                        Hijos =
                        {
                           new Nodo
                           {
                                Valor = "*",
                                Hijos =
                                {
                                    new Nodo
                                    {
                                        Valor = "4"
                                    },
                                    new Nodo
                                    {
                                        Valor = "6"
                                    }
                                }
                            }
                        }
                    }
                }

            };
            Console.WriteLine("OPERACION 2");
            Console.WriteLine("(4*30)*(30/3)/(4*6)");
            Console.WriteLine("Ingresa tu respuesta: ");
            respuestas = Console.ReadLine();
            var respuesta1 = new Respuesta(respuestas)
            {
                Respuestas = respuestas
            };
            Console.WriteLine($"{respuesta1.VerificarRespuesta2()}");

            Console.WriteLine("Esta segunda operacion fue hecha con estructura de un arbol el cual tuvo:");
            Console.WriteLine($"Numero de hojas: {manejadorArbol.NumeroHojas(raiz1)}");
            Console.WriteLine($"Numero de nodos: {manejadorArbol.NumeroNodos(raiz1)}");
            Console.WriteLine($"Numero de niveles: {manejadorArbol.NumeroNiveles(raiz1)}");

            Console.WriteLine("---------------FIN----------------");
        }

    }

   
}

