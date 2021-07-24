using System;
using System.Collections.Generic;

namespace Ordenamiento
{
    class Ordenador//propiedades sobre los T => Icomparacion
    {
        internal List<IComparable> Ordenar(List<IComparable> desordenados)
        {            
            for (var posicionActual = 0; posicionActual < desordenados.Count - 1; posicionActual++)
            {
                var posicionMenor = posicionActual;
                posicionMenor = Menor(desordenados, posicionMenor);

                var intercambio = desordenados[posicionMenor];
                desordenados[posicionMenor] = desordenados[posicionActual];
                desordenados[posicionActual] = intercambio;
                
            }
            return desordenados;
        }
        internal int Menor(List<IComparable> desordenados,int posicionMenor)
        {
            
            for (int posicionActual = posicionMenor; posicionActual < desordenados.Count; posicionActual++)
            {
                if (desordenados[posicionMenor].CompareTo (desordenados[posicionActual])>0)
                {
                    posicionMenor = posicionActual;
                }
            }
            return posicionMenor;
        }
    }
}