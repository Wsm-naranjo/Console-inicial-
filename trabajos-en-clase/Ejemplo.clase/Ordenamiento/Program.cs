using System;
using System.Collections.Generic;

namespace Ordenamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ordenamiento!");

            Ordenador ordenador = new Ordenador();
            var desordenadosCarros = new List<IComparable>
            {
                new Carro{Precio=10},
                new Carro{Precio=13},
                new Carro{Precio=12},
                new Carro{Precio=80},
                new Carro{Precio=5}
            };

            var ordenadosCarros = ordenador.Ordenar(desordenadosCarros);
            foreach (Carro Carro in ordenadosCarros)
                Console.WriteLine(Carro.ToString());

            var puestosTrabajo = new List<IComparable>
            {
                new PuestoTrabajo{Posicion =1},
                new PuestoTrabajo{Posicion =9},
                new PuestoTrabajo{Posicion =7},
                new PuestoTrabajo{Posicion =2},
                new PuestoTrabajo{Posicion =4}
            };
            var puestosTrabajoOrdenados = ordenador.Ordenar(puestosTrabajo);
            foreach (Carro Carro in ordenadosCarros)
                Console.WriteLine(Carro.ToString());




            //List<float> desordenados1 = new List<float> { 3.1f, 8.2f, 1.5f, 9.9f, 5.01f, 18.009f, -1.0f };
            //List<float> ordenados1 = ordenador.Ordenar(desordenados);

            //foreach (var numero in ordenados)
            //{
            //    Console.WriteLine(numero);
            //}

        }
    }
}
