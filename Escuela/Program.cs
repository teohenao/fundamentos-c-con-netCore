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
            var curso1 = new Curso(){
                Nombre ="101"
            };
              var curso2 = new Curso(){
                Nombre ="201"
            };
              var curso3 = new Curso(){
                Nombre ="301"
            };
            escuela.TipoEscuela = TiposEscuela.Primaria;
            Console.WriteLine(escuela);
            System.Console.WriteLine("====================");
            Console.WriteLine(curso1.Nombre +" , "+curso2.UniqueId);
            Console.WriteLine($"{curso2.Nombre},{curso2.UniqueId}");
            Console.WriteLine(curso3);
        }
    }
}
