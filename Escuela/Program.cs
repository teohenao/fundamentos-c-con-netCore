using System;
using School.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("escuela teo", 2019, TiposEscuela.Prescolar,
            pais: "coooloommmbia", ciudad: "Calarcaaa"
            );

            escuela.Cursos = new Curso[]{
            new Curso(){Nombre = "101",},
            new Curso(){Nombre = "201"},
            new Curso(){Nombre = "301"}
            };

            ImprimirCursosEscuela(escuela);


        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("========Lista cursos escuela========");
            //el signo de interrogacion significa que no verificara cursos salvo que escuela sea diferente de null
            if(escuela?.Cursos==null)
            return;
            else{
                 foreach (var curso in escuela.Cursos)
                {
                 WriteLine($"nombre: {curso.Nombre}, id: {curso.UniqueId}");
                }

            }
        
        }


    }
}
