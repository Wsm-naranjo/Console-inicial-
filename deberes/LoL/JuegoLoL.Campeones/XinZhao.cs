using System;

namespace JuegoLoL.Campeones
{
    public class XinZhao
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
            var saludar = $"Hola me llamo {this.Nombre}, apodado {this.Apodo} ";
            return saludar;
        }
        public string Datos()
        {
            var datos = "Mis estadisticas son:" + Environment.NewLine + $"Mi velocidad en desplazarme por el mapa es {this.Velocidad},por eso soy mas utilizado como soporte." + Environment.NewLine + $"Mi ataque es de {this.Ataque},soy muy bueno para ataques a distancia o tirador." + Environment.NewLine + $"Mi vida es de {this.Vida} y mi Mama es de {this.Mana}.";
            return datos;
        }
        public string HabilidadAtaque()
        {
            var habilidadAtaque = $"Mi habilidad {this.Habilidad},Los 3 siguientes ataques infligen más daño. El tercero lanza a un oponente por los aires.";
            return habilidadAtaque;
        }
    }
}
