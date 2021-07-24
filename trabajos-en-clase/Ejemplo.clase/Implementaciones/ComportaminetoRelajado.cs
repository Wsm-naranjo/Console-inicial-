using Abstracciones;

namespace Implementaciones
{
    public class ComportaminetoRelajado : Comportamiento
    {
        public override string Caminar()
        {
            return "Estoy caminando sabroso";
        }
        public override string Informar()
        {
            return "Estoy informando a gusto";
        }
    }
}