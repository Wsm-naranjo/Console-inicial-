using System;
using System.Collections.Generic;
using Ejemplo.entidades;
namespace Ejemplo.vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Persona persona = new Profesor
            {
                Nombre = "Alanis",
                Apellido = "Morison",
                Especialidad = "Inteligencia artificail"
            };
            Console.writeLIne(persona.Saludar());

            var asignatura = new Asignatura
            {
                Nombre = "Programacion Visual"
            };
            var asignatura1 = new Asignatura
            {
                Nombre = "Administraciomn"
            };

            var curso = new Curso
            {
                Asignatura = asignatura1
            };
            var curso1 = new Curso
            {
                Asignatura = asignatura1
            };
            var cursos = new List<Curso>
            {
                curso,
                curso1
            };


            var estudiante = new Estudiante
            {
                Nombre = "Sebastian",
                Apellido = "Naranjo",
                Cursos = cursos
            };

            curso.Estudiantes = new List<Estudiante> { estudiante };

        }
    }
}
