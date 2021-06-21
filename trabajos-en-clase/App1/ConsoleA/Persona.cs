namespace ConsoleA
{
    class Persona
    {
        string nombre;
        string apellido;
        int edad;
        int peso;
        float nota;
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public int Peso { get { return peso; } set { peso = value; } }
        public float Nota { get { return nota; } set { nota = value; } }

        public string NombreCompleto
        {
            get { return $"{this.Nombre} {this.Apellido}"; } //interpolacion
        }
        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }        

        public string Saludar()
        {
            return $"Hola... ¿como estas?, Mi nombre es {this.Nombre}";
        }
       
    }
}


















