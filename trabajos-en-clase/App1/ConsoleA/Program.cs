using System;

namespace ConsoleA
{
    class Program
    {
        static void Main(string[] datosPersonas)
        {
            Console.WriteLine("Escribe tu nombre: ");
            var nombre = Console.ReadLine();

            Console.WriteLine("Escribe tu apellido: ");
            var apellido = Console.ReadLine();

            Console.WriteLine("Escribe tu peso: ");
            var peso = int.Parse(Console.ReadLine());

            //ToDo:Sebastian, debo leer 10 datos de una persona utilizando todos esos tipos de datos
            ///float
            //double
            //DateTime // System.DateTime
            //bool

            Console.WriteLine("Escribe tu edad: ");
            var edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Escribe tu nota: ");
            var nota = float.Parse(Console.ReadLine());


            var amigo = new Persona
            {
                Nombre = nombre,
                Apellido = apellido,
                Peso = peso,
                Edad = edad,
                Nota = nota
            };

            
            Console.WriteLine($"Hola {amigo.Nombre}" );
            Console.WriteLine($"Tu apellido es: {amigo.Apellido}");
            Console.WriteLine($"Tu edad es: {amigo.Edad}");
            Console.WriteLine($"Tu peso es: {amigo.Peso}");
            Console.WriteLine($"Tu nota es: {amigo.Nota}");

            Persona vecina = new("Julia", "RioFrio");
            Console.WriteLine($"Mi vecina se llama {vecina.NombreCompleto}");

            Console.Write("Escribe cualquier letra para terminar");

            Console.ReadLine();

        }


    }
}


















