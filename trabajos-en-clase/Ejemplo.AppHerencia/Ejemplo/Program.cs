using System;
using System.IO;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!");
            try
            {
                FileStream fs = File.Create("C:\\Stream\\aquiEstoy.txt");
            }
            catch (UnauthorizedAccessException e)
            {
                System.Diagnostics.Trace.TraceError(e.Message);
                Console.WriteLine("No tengo acceso de escritura consulte a Sebastian");
            }
            catch (Exception e)
            {
                System.Diagnostics.Trace.TraceError(e.Message);
                Console.WriteLine("No tengo acceso de escritura consulte a Sebastian");

            }
            Console.WriteLine("Chao");
        }
    }
}
