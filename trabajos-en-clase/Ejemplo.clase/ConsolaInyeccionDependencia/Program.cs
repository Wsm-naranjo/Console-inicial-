using System;
using Abstracciones;
using Implementaciones;

namespace ConsolaInyeccionDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Comportamiento comportamiento = new ComportaminetoNormal();

            Console.WriteLine("En Quito");
            Guia guia = new Guia(comportamiento);//Inyeccion por el Constructor            
            Console.WriteLine(guia.Caminar());

            Console.WriteLine("En una jumgla africana (Leones), selva del Asia (triges)");
            guia.Comportamiento = new ComportaminetoCauteloso();//Inyeccion por la Propiedad
            Console.WriteLine(guia.Caminar());

            Console.WriteLine("En Pedernales");
            guia.Comportamiento = new ComportaminetoRelajado();
            Console.WriteLine(guia.Caminar());

        }
    }

    
}
