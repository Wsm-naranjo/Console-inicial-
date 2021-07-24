using System.Collections.Generic;

namespace Arbol
{
    public class Provincia
    {
        public string Nombre { get; set; }
        public List<Cantones> Canton { get; internal set; } = new List<Cantones>();

        public int ObtenerHabitantes()
        {
            //return new Random().Next();
            var totalHabitantes = 0;
            foreach (Cantones actual in Canton)
            {
                int habitantes = actual.ObtenerHabitantes();
                totalHabitantes += habitantes;
            }
            return totalHabitantes;
            //TODO: Sebastian, terminar el codigo.

        }
    }
}