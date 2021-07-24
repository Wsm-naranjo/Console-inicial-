using Abstracciones;

namespace Implementaciones
{
    public class ComportaminetoNormal : Comportamiento
    {
        public override string Caminar()
        {
            return "Estoy caminando";
        }
        public override string Informar()
        {
            return "Estoy informando tranquilo";
        }
    }
}