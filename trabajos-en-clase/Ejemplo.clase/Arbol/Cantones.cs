using System.Collections.Generic;

namespace Arbol
{
    public class Cantones
    {
        public string Nombre { get; set; }
        public List<Parroquias> Parroquia { get; internal set; } = new List<Parroquias>();

        public int ObtenerHabitantes()
        {
            var totalHabitantes = 0;
            foreach (Parroquias actual in Parroquia)
            {
                int habitantes = actual.ObtenerHabitantes();
                totalHabitantes += habitantes;
            }
            return totalHabitantes;
        }
    }
}