using System;
using JuegoLoL.Campeones;

namespace JuegoLoL
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Conoce League of Legends");
                Console.WriteLine("Ingresa el numero para cococer mas de los campiones:" +
                "\n1.-Kai'sa" +
                "\n2.-Xin Zhao" +
                "\n3.-Jhin" +
                "\n4.-Lulu" +
                "\n5.-Lee Sin" +
                "\n0.-Para salir");
                string opcion = null;
                opcion = Console.ReadLine().ToString();

            switch (opcion)
            {
                case "1":
                    {
                        Kaisa Kaisa1 = new Kaisa();
                        Kaisa1.Nombre = "Kai'sa";
                        Kaisa1.Apodo = "La hija del vacio";
                        Kaisa1.Habilidad = "Lluvia de Icathia";
                        Kaisa1.Vida = "554.4";
                        Kaisa1.Mana = "8.2";
                        Kaisa1.Rango = "500";
                        Kaisa1.Velocidad = "335";
                        Kaisa1.Armadura = "33.04";
                        Kaisa1.Ataque = "62.46";
                        Console.WriteLine(Kaisa1.Cargar());
                        Console.WriteLine(Kaisa1.Saludar());
                        Console.WriteLine(Kaisa1.Datos());
                        Console.WriteLine(Kaisa1.HabilidadAtaque());
                    }
                    break;
                case "2":
                    {
                        XinZhao XinZhao1 = new XinZhao();
                        XinZhao1.Nombre = "Xin Zhao";
                        XinZhao1.Apodo = "el Senescal de Demacia";
                        XinZhao1.Habilidad = "Golpe de tres garras";
                        XinZhao1.Vida = "591 – 2070";
                        XinZhao1.Mana = "274 – 869";
                        XinZhao1.Rango = "175";
                        XinZhao1.Velocidad = "345";
                        XinZhao1.Armadura = "25.9 – 85.4";
                        XinZhao1.Ataque = "58 – 114";
                        Console.WriteLine(XinZhao1.Cargar());
                        Console.WriteLine(XinZhao1.Saludar());
                        Console.WriteLine(XinZhao1.Datos());
                        Console.WriteLine(XinZhao1.HabilidadAtaque());
                    }
                    break;
                case "3":
                    {
                        Jhin Jhin1 = new Jhin();
                        Jhin1.Nombre = "Jhin";
                        Jhin1.Apodo = "el Virtuoso";
                        Jhin1.Habilidad = "Abajo el telón";
                        Jhin1.Vida = "540";
                        Jhin1.Mana = "300 ";
                        Jhin1.Rango = "550";
                        Jhin1.Velocidad = "330";
                        Jhin1.Armadura = "29 (+ 3.5)";
                        Jhin1.Ataque = " 61 (+ 4)";
                        Console.WriteLine(Jhin1.Cargar());
                        Console.WriteLine(Jhin1.Saludar());
                        Console.WriteLine(Jhin1.Datos());
                        Console.WriteLine(Jhin1.HabilidadAtaque());
                    }
                    break;
                case "4":
                    {
                        Lulu Lulu1 = new Lulu();
                        Lulu1.Nombre = "Lulu";
                        Lulu1.Apodo = "el Hada Hechicera";
                        Lulu1.Habilidad = "Crecimiento salvaje";
                        Lulu1.Vida = "553 – 1811";
                        Lulu1.Mana = "292 – 1227";
                        Lulu1.Rango = "550";
                        Lulu1.Velocidad = "325";
                        Lulu1.Armadura = "19.2 – 82.1)";
                        Lulu1.Ataque = "46 – 91";
                        Console.WriteLine(Lulu1.Cargar());
                        Console.WriteLine(Lulu1.Saludar());
                        Console.WriteLine(Lulu1.Datos());
                        Console.WriteLine(Lulu1.HabilidadAtaque());
                    }
                    break;
                case "5":
                    {
                        LeeSin LeeSin1 = new LeeSin();
                        LeeSin1.Nombre = "Lee Sin";
                        LeeSin1.Apodo = "el Monje Ciego";
                        LeeSin1.Habilidad = "Ira del dragón";
                        LeeSin1.Vida = "571 – 2016";
                        LeeSin1.Energia = "200";
                        LeeSin1.Rango = "125";
                        LeeSin1.Velocidad = "350";
                        LeeSin1.Armadura = "24.2 – 87.1";
                        LeeSin1.Ataque = "61 – 116";
                        Console.WriteLine(LeeSin1.Cargar());
                        Console.WriteLine(LeeSin1.Saludar());
                        Console.WriteLine(LeeSin1.Datos());
                        Console.WriteLine(LeeSin1.HabilidadAtaque());
                    }
                    break;
                case "0":
                    Console.WriteLine("Aplasta cualquier tecla para salir");
                    break;
                default:
                    Console.WriteLine("Eleccion erronea!!!!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
