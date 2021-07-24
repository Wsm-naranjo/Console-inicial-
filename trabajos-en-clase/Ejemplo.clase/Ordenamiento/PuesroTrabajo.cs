using System;

namespace Ordenamiento
{
    class PuestoTrabajo : IComparable
    {
        public int Posicion { get; set; }

        public int CompareTo(object obj)
        {
            return Posicion - ((PuestoTrabajo)obj)).Posicion;
        }
    }
}