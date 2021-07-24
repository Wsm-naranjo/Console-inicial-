using Abstracciones;

namespace Implementaciones
{
    public class ComportaminetoCauteloso : Comportamiento
    {
        public override string Caminar()
        {
            return "Estoy caminando con cuidado";
        }
        public override string Informar()
        {
            return "Estoy informando hablando con cuidado";
        }

    }
}