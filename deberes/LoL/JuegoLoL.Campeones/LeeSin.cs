using System;

namespace JuegoLoL.Campeones
{
    public class LeeSin
    {
        public string Nombre { get; set; }
        public string Apodo { get; set; }
        public string Habilidad { get; set; }
        public string Vida { get; set; }
        public string Energia { get; set; }
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
            var datos = "Mis estadisticas son:" + Environment.NewLine + $"Mi velocidad es desplazarme por el mapa es {this.Velocidad},por eso soy mas de jungle mientras mas experiencia recolecte mas puedo tanquear en el pvp contra los enemigos." + Environment.NewLine + $"Mi ataque es de {this.Ataque} y con mi habiilidad a el maximo puedo llegar a tener 900 de hit en un solo ataque." + Environment.NewLine + $"Mi vida es de {this.Vida}, y yo no cuento con mana solo con energia y mi energia es de {this.Energia}.";
            return datos;
        }
        public string HabilidadAtaque()
        {
            var habilidadAtaque = $"Mi habilidad {this.Habilidad},realiza una potente patada giratoria, que lanza hacia atrás al objetivo e inflige daño físico a él y a todos los enemigos con los que impacte. Estos últimos salen por los aires durante un breve tiempo. Esta técnica se la enseñó Jesse Perring, aunque Lee Sin no patea a los jugadores fuera del mapa.";
            return habilidadAtaque;
        }
    }
}
