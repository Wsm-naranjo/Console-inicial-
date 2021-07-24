using System;

namespace Ejemplo.AppHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Herencia POO!");

            //Rectangulo figura1 = new Rectangulo();
            //figura1.Altura = 10f;
            //figura1.Base = 3f;
            //var areaFigura1 = figura1.Area();
            //Console.WriteLine($"El area es figura 1: {areaFigura1}");

            var figura2 = new Cuadrado();
            figura2.Altura = 10f;
            figura2.Base = 3f;
            var areaFigura2 = figura2.Area();
            Console.WriteLine($"El area es figura 2: {areaFigura2}");
        }
    }
}
