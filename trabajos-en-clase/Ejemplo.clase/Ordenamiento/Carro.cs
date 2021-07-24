using System;
namespace Ordenamiento
{
    internal class Carro : IComparable
    {
        public int Precio { get; set; }
        public DateTime FechaEnsamblado { get; set; }
        public int CompareTo(Carro otroCarro)
        {
            return this.Precio - otroCarro.Precio;
        }
        bool Comparar(object otroCarro)
        {
            return Precio - ((Carro)otroCarro)).Precio;
        }
    }
}
