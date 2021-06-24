using System;

namespace Arbol
{
    public class Parroquias
    {
        public string Nombre { get; internal set; }
        public int Habitantes { get ; set; }

        public int ObtenerHabitantes()
        {
            var totalHabitantes = Habitantes;            
            return totalHabitantes;
        }
    }
}