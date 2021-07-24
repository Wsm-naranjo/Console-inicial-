using System;
using System.Collections.Generic;

namespace Arbol
{
    internal class Pais
    {       
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public static List<Provincia> Provincias { get; internal set; } = new List<Provincia>();

        public static int ObtenerHabitantes()
        {
            var totalHabitantes = 0;
            foreach (Provincia actual in Provincias)
            {
                int habitantes = actual.ObtenerHabitantes();
                totalHabitantes += habitantes; 
            }
            return totalHabitantes;
        }
    }   
}