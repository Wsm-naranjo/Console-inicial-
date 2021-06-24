using System;
using System.Collections.Generic;

namespace Arbol
{
    class Program
    {
        static void Main(string[] args)
        {
            var pais = new Pais
            {
                Nombre = "Ecuador",
                Descripcion = "El Pais mas feliz del mundo"
            };
            Pais.Provincias.Add(
                new Provincia
                {
                    Nombre = "Loja",
                    Canton = new List<Cantones>
                    {
                        new Cantones
                        {
                            Nombre = "Loja",
                            Parroquia = new List<Parroquias>
                            {
                                new Parroquias
                                {
                                    Nombre ="Chantaco",
                                    Habitantes = 1500
                                },
                                new Parroquias
                                {
                                    Nombre ="Chuquiribamba",
                                    Habitantes = 4000//5500

                                }
                            }
                        },
                        new Cantones
                        {
                            Nombre = "Catamayo",
                            Parroquia = new List<Parroquias>
                            {
                                new Parroquias
                                {
                                    Nombre ="Guayquichuma",
                                    Habitantes = 6500
                                },
                                new Parroquias
                                {
                                    Nombre ="San José",
                                    Habitantes = 100//12100

                                }
                            }
                        }
                    }
                }
               );
            Pais.Provincias.Add(
                new Provincia
                { 
                    Nombre = "Pichincha",
                    Canton = new List<Cantones>
                    {
                        new Cantones
                        {
                            Nombre = "Quito",
                            Parroquia = new List<Parroquias>
                            {
                                new Parroquias
                                {
                                    Nombre ="Guayllabamba",
                                    Habitantes = 8500//20600
                                },
                                new Parroquias
                                {
                                    Nombre ="Solanda",
                                    Habitantes = 14000//34600

                                }
                            }
                        },
                        new Cantones
                        {
                            Nombre = "Cayambe",
                            Parroquia = new List<Parroquias>
                            {
                                new Parroquias
                                {
                                    Nombre ="Ayora",
                                    Habitantes = 6500//41100
                                },
                                new Parroquias
                                {
                                    Nombre ="Olmedo",
                                    Habitantes = 3000//44100

                                }
                            }
                        }
                    }
                });
            Console.WriteLine($"El total de habitantes de {pais.Nombre} es:");
            Console.WriteLine(Pais.ObtenerHabitantes());
        }
    }
}
