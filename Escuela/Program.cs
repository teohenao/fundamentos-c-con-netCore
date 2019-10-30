using System;
using System.Collections.Generic;
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

            escuela.Cursos = new List<Curso>(){
                 new Curso(){Nombre = "101",},
            new Curso(){Nombre = "201"},
            new Curso(){Nombre = "301"}
            };

            Curso c = new Curso();
            c.Nombre = "102";
            c.TipoJornada = TiposJornada.Noche;
            escuela.Cursos.Add(c);

            List<Curso> lista2Cursos = new List<Curso>();
            Curso c1 = new Curso();
            c1.Nombre = "5A";
            c1.TipoJornada = TiposJornada.Tarde;

            Curso c2 = new Curso();
            c2.Nombre = "6G";
            c2.TipoJornada = TiposJornada.Noche;
            lista2Cursos.Add(c1);
            lista2Cursos.Add(c2);
            escuela.Cursos.AddRange(lista2Cursos);

            Curso temp = new Curso();
            temp.Nombre="vacacional";
            temp.TipoJornada = TiposJornada.Tarde;
            escuela.Cursos.Add(temp);

            ImprimirCursosEscuela(escuela);
            WriteLine("temp.hasCode"+temp.GetHashCode());
            escuela.Cursos.Remove(temp);
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
    }
}
