using Ejemplo.AppHerencia;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Herencia.Test
{
    [TestClass]
    public class CuenadoHeredoCuadradoDeRectangulo
    {
        [TestMethod]
        public void EntoncesElAreaFunciona()
        {
            var altura = 10f;
            var basecuadrado = 10f;
            var areaEsperada = 9;

            var figura1 = new Cuadrado
            {
                Altura = alturaFigura,
                Base = baseFigura
            };
            var areaFigura1 = figura1.Area();
            $"El area es figura 2: {areaFigura2}";
        }
    }
}
