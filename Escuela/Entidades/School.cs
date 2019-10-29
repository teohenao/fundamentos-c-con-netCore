namespace   School.Entidades
{
    //no importa el nombre de la clase coincida con el de la clase
    class Escuela
    {
        string nombre;
        public string Nombre{
            get{ return nombre;}
            set{ nombre = value.ToUpper();}
        }

        //asi el, se encarga de generar la logica de arriba de get setm y incluso los declara
        public int añoCreacion{get;set;}

        public string Pais { get; set; }
        public string Ciudad { get; set; }


        //inicializador- constructor opcion 1
        // public Escuela(string nombre,int añoCreacion){
        //     this.nombre = nombre;
        //     this.añoCreacion = añoCreacion;
        // }
     
        //opcion2 inicializador
        public Escuela(string nombre,int año)=> (Nombre,añoCreacion) = (nombre,año);

    }
}