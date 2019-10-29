using System;
using School.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("escuela teo", 2019, TiposEscuela.Prescolar,
            pais: "coooloommmbia", ciudad: "Calarcaaa"
            );

            var arregloCursos = new Curso[3];
            arregloCursos[0] = new Curso()
            {
                Nombre = "101"
            };
            arregloCursos[1] = new Curso()
            {
                Nombre = "201"
            };
            arregloCursos[2] = new Curso()
            {
                Nombre = "301"
            };
            escuela.TipoEscuela = TiposEscuela.Primaria;
            Console.WriteLine(escuela);
            System.Console.WriteLine("=========cursos===========");
            imprimirCursosWhile(arregloCursos);
            imprimirCursosDoWhile(arregloCursos);
            imprimirCursosFor(arregloCursos);
            imprimirCursosForEach(arregloCursos);
        }


        private static void imprimirCursosWhile(Curso[] arregloCursos)
        {
            int count = 0;
            while (count < arregloCursos.Length)
            {
                Console.WriteLine(arregloCursos[count].Nombre);
                count++;
            }
        }

        private static void imprimirCursosDoWhile(Curso[] arregloCursos)
        {
            int count = 0;
            do
            {
                Console.WriteLine(arregloCursos[count].Nombre);
                count++;


                //si se coloca en el while 
                //count ++, primero pregunta y despues aumenta
                //++count primero aumenta y despues pregunta
            } while (count < arregloCursos.Length);
        }


        private static void imprimirCursosFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                Console.WriteLine(arregloCursos[i].Nombre);
            }

        }

        private static void imprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                Console.WriteLine(curso.Nombre);
            }
        }

    }
}
