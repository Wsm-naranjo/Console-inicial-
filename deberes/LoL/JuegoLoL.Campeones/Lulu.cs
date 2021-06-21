using System;
namespace JuegoLoL.Campeones
{
    public class Lulu
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
            var datos = "Mis estadisticas son:" + Environment.NewLine + $"Mi velocidad es desplazarme por el mapa es {this.Velocidad},soy muy buena en el centro del mapa y tambien si gano experiencia gano mi habilidad que da un plus a todos los aliados." + Environment.NewLine + $"Mi ataque es de {this.Ataque},sirvo de ataques a distancia." + Environment.NewLine + $"Mi vida es de {this.Vida} y mi Mama es de {this.Mana}.";
            return datos;
        }
        public string HabilidadAtaque()
        {
            var habilidadAtaque = $"Mi habilidad {this.Habilidad}, crecer a un aliado. Los enemigos cercanos salen despedidos y el aliado afectado consigue gran cantidad de vida adicional. Durante los siguientes segundos, el aliado obtiene además un aura que ralentiza a los enemigos próximos.";
            return habilidadAtaque;
        }
    }
}
