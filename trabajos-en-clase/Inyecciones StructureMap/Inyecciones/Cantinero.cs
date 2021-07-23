using StructureMap;
using Dependencias;
using Interfaz;

namespace Inyecciones
{
    public class Cantinero
    {
        public static IContainer InitContainer(string eleccion)
        {
            if(eleccion== "1")
            {
                var container1 = new Container(c => c.For<IBebida>().Use<Bebida1>());
                return container1;
            }
            else
            {
                var container2 = new Container(c => c.For<IBebida>().Use<Bebida2>());
                return container2;
            }            
        }
    }
}
