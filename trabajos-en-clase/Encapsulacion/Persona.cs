using System;

namespace Encapsulacion
{
    internal abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public void Saludar()
        {
            return $"Hola, me llamo {this.Nombre}, espero te encuentres bien";
        }
    }
}
