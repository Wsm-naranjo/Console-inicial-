using System;
using System.IO;

namespace Console.Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FileStream fs = File.Create("C:\\aquiEstoy.txt");
            Console.WriteLine("Chao");
        }
    }
}
