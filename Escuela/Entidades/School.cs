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
        public string Pais { get; set;}
        public string Ciudad { get; set;}
        public TiposEscuela TipoEscuela {get; set;}     
        //inicializador
        public Escuela(string nombre,int año)=> (Nombre,añoCreacion) = (nombre,año);
        //ToString del objeto
        public override string ToString()
        {
            return $"Nombre: {Nombre},Tipo: {TipoEscuela} \nPais: {Pais}, Ciudad: {Ciudad}";
        }

    }
}