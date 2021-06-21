using System;
namespace JuegoLoL.Campeones
{
    public class Jhin
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
            var datos = "Mis estadisticas son:" + Environment.NewLine + $"Mi velocidad es desplazarme por el mapa es {this.Velocidad},por eso soy mas utilizado como tirador y soporte me desarrollo muy bien el carrill paso del Dragon." + Environment.NewLine + $"Mi ataque es de {this.Ataque},y cada tercer tiro que hago el daño es aumenta a el triple." + Environment.NewLine + $"Mi vida es de {this.Vida} y mi Mama es de {this.Mana}.";
            return datos;
        }
        public string HabilidadAtaque()
        {
            var habilidadAtaque = $"Mi habilidad {this.Habilidad}, concentra su energía y transforma Susurro en un megacañón de hombro capaz de realizar 4 superdisparos de gran alcance, que atraviesan a los súbditos y a los monstruos pero se detienen en el primer campeón impactado. Susurro incapacita a los enemigos impactados, los ralentiza e inflige daño de ejecución. El cuarto disparo se prepara con sumo cuidado, tiene una potencia épica y garantiza un impacto crítico.";
            return habilidadAtaque;
        }
    }
}
