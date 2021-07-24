namespace Arbol2
{
    class Respuesta
    {
        public Respuesta(string respuestas)
        {
            Respuestas = respuestas;
        }        
        internal string VerificarRespuesta()
        {
            var resultadoPositivo = "Respuesta correcta.";
            var resultadoNegativo = "Respuesta incorrecta.";

            if (Respuestas != null && Respuestas == "4")
                return resultadoPositivo;
            else
                return resultadoNegativo;
        }
        internal string VerificarRespuesta2()
        {
            var resultadoPositivo = "Respuesta correcta.";
            var resultadoNegativo = "Respuesta incorrecta.";

            if (Respuestas != null && Respuestas == "50")
                return resultadoPositivo + "WOOW! Lo lograste :)";
            else
                return resultadoNegativo + " :( Mejor suerte ala proxima.";
        }
        public string Respuestas { get; set; }
    }
}

