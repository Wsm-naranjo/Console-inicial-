using System;
using Interfaz;

namespace Inyecciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Utilizando StructureMap
            Console.WriteLine("----------------Bienvenido---------------");
            Console.WriteLine("Que bebida escogeras, hoy tenemos:");
            Console.WriteLine(" 1.-Micheleda" +
                "\n 2.-Margarita");
            Console.WriteLine("Ingresa el numero de tu eleccion:");
            var eleccion = Console.ReadLine();

            var cantinero = Cantinero.InitContainer(eleccion).GetInstance<IBebida>();
            var bebida = cantinero.GetBebida();
            Console.WriteLine($"OK,Estoy preparando tu... {bebida}");
        }
    }
}
