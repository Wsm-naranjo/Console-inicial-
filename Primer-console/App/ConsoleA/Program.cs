using System;

namespace ConsoleA
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length > 1)
            {
                Console.WriteLine($"Hay {args.Length} argumentos");
                Console.WriteLine($"Hola tu nombre es: {args[0]}");
                if(args.Length > 1)
                Console.WriteLine($"Hola tu apellido es: {args[1]}");
            }
            else
                Console.WriteLine("No hay argumentos");
            Console.Read();
        }
    }
}
