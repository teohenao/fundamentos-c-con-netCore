using System;
using System.Collections.Generic;
using School;
using School.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            ImprimirCursosEscuela(engine.Escuela);
        }
        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("========Lista cursos escuela========");
            if(escuela?.Cursos==null)
            return;
            else{
                 foreach (var curso in escuela.Cursos)
                {
                 WriteLine($"nombre: {curso.Nombre}, id: {curso.UniqueId}");
                }
            }
        }

        private static bool predicado(Curso c)
        {
            return c.Nombre == "vacacional";
        }
    }
}
