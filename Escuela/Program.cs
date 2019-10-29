using System;
using School.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("escuela teo",2019,TiposEscuela.Prescolar,
            pais:"coooloommmbia",ciudad:"Calarcaaa"
            );

            var arregloCursos = new Curso[3];
            arregloCursos [0] = new Curso(){
                Nombre ="101"
            };
            arregloCursos [1] = new Curso(){
                Nombre ="201"
            };
            arregloCursos [2] = new Curso(){
                Nombre ="301"
            };
            escuela.TipoEscuela = TiposEscuela.Primaria;
            Console.WriteLine(escuela);
            System.Console.WriteLine("=========cursos===========");
            imprimirCursos(arregloCursos);
        }

        private static void imprimirCursos(Curso[] arregloCursos)
        {
          int count = 0;
          while (count < arregloCursos.Length)
          {
              Console.WriteLine(arregloCursos[count].Nombre);
              count++;
          }
        }
    }
}
