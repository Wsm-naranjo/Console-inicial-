using System;

namespace JuegoLoL.Campeones
{
    public class Kaisa
    {
        public string Nombre { get; set; }
        public string Apodo { get; set; }
        public string Habilidad { get; set; }
        public string Vida { get; set; }
        public string Mana { get; set; }
        public string Rango { get; set; }
        public string Velocidad { get; set; }
        public string Armadura { get; set; }
        public string Ataque { get; set; }
        public string Cargar()
        {
            var cargar = $"Historia de {this.Nombre} Cargando....";
            return cargar;
        }
        public string Saludar()
        {
            var saludar = $"Hola me llamo {this.Nombre}, apodada {this.Apodo} ";
            return saludar;
        }
        public string Datos()
        {
            var datos = "Mis estadisticas son:" + Environment.NewLine + $"Mi velocidad en desplazarme por el mapa es {this.Velocidad},por eso soy mas utilizada para el centro de los mapas." + Environment.NewLine + $"Mi ataque es de {this.Ataque},con mi habilidad de ataque rapido el daño es aun mayor." + Environment.NewLine + $"Mi vida es de {this.Vida} y mi Mama es de {this.Mana}.";
            return datos;
        }
        public string HabilidadAtaque()
        {
            var habilidadAtaque = $"Mi habilidad {this.Habilidad}, infringe un daño mayor y libera una ráfaga de proyectiles que se distribuyen equitativamente entre los enemigos cercanos.";
            return habilidadAtaque;
        }

    }
}
